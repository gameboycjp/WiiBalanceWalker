//----------------------------------------------------------------------------------------------------------------------+
// WiiBalanceWalker v0.5, by Shachar Liberman
// Originally Released by Richard Perry from GreyCube.com - Under the Microsoft Public License.
//
// released for windows 10 x64 systems, x86 should be supported too.
//
// Uses lshachar's WiimoteLib DLL:                  https://github.com/lshachar/WiimoteLib
// Uses the 32Feet.NET bluetooth DLL:               http://32feet.codeplex.com/
// Uses vJoy device driver (by Shaul Eizikovich):   http://vjoystick.sourceforge.net/site/index.php/download-a-install/download
// (Previous to WiiBalanceWalker v0.5
//  VJoy by headsoft was used)                      http://headsoft.com.au/index.php?category=vjoy
//----------------------------------------------------------------------------------------------------------------------+

using System;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;
using WiimoteLib;
using InputManager;
using CytraX.WS;
using System.Threading.Tasks;

namespace WiiBalanceWalker
{
    public partial class FormMain : Form
    {
        System.Timers.Timer infoUpdateTimer = new System.Timers.Timer() { Interval = 50,     Enabled = false };
        System.Timers.Timer joyResetTimer   = new System.Timers.Timer() { Interval = 240000, Enabled = false };

        Wiimote wiiDevice     = new Wiimote();
        DateTime jumpTime     = DateTime.UtcNow;

        bool setCenterOffset = false;
        bool resetCenterOffsetPossible = false;

        float naCorners     = 0f;
        float oaTopLeft     = 0f;
        float oaTopRight    = 0f;
        float oaBottomLeft  = 0f;
        float oaBottomRight = 0f;
        Task webSocketTask;

        public FormMain()
        {
            webSocketTask = WebSocketComponent.Start(8123);
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Setup a timer which controls the rate at which updates are processed.

            infoUpdateTimer.Elapsed += new ElapsedEventHandler(infoUpdateTimer_Elapsed);

            // Load screen size settings.

            numericScreenWidth.Value  = Properties.Settings.Default.ScreenWidth;
            numericScreenHeight.Value = Properties.Settings.Default.ScreenHeight;
            numericAreaWidth.Value    = Properties.Settings.Default.AreaWidth;
            numericAreaHeight.Value   = Properties.Settings.Default.AreaHeight;

            // Load saved preference.

            checkBox_DisableActions.Checked = Properties.Settings.Default.DisableActions;
            checkBox_StartupAutoConnect.Checked = Properties.Settings.Default.EnableJoystick;
            checkBox_AutoTare.Checked = Properties.Settings.Default.EnableJoystick;
            checkBox_StartMinimized.Checked = Properties.Settings.Default.StartMinimized;

            if (checkBox_StartupAutoConnect.Checked)
            { 
                button_Connect.PerformClick();
            }

            if (checkBox_StartMinimized.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void button_SetCenterOffset_Click(object sender, EventArgs e)
        {
            if (resetCenterOffsetPossible && wiiDevice.WiimoteState.BalanceBoardState.WeightKg <= 5)
            {
                naCorners = 0f;
                oaTopLeft = 0f;
                oaTopRight = 0f;
                oaBottomLeft = 0f;
                oaBottomRight = 0f;
                button_SetCenterOffset.Enabled = false;
                resetCenterOffsetPossible = false;
                button_SetCenterOffset.Text = "Set current balance as center";
                //toolTip1.SetToolTip(button_SetCenterOffset, "While standing or sitting on the balance board, click this button to set your current balance point as center");
            }

            else
            { 
                setCenterOffset = true;
                //toolTip1.SetToolTip(button_SetCenterOffset, "Revert back to the original center balance point, for the X/Y controls");
            }
        }

        private void button_ResetDefaults_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            this.Close();
        }

        private void button_BluetoothAddDevice_Click(object sender, EventArgs e)
        {
            var form = new FormBluetooth();
            form.ShowDialog(this);
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                // Find all connected Wii devices.

                var deviceCollection = new WiimoteCollection();
                deviceCollection.FindAllWiimotes();

                for (int i = 0; i < deviceCollection.Count; i++)
                {
                    wiiDevice = deviceCollection[i];

                    // Device type can only be found after connection, so prompt for multiple devices.

                    if (deviceCollection.Count > 1)
                    {
                        var devicePathId = new Regex("e_pid&.*?&(.*?)&").Match(wiiDevice.HIDDevicePath).Groups[1].Value.ToUpper();

                        var response = MessageBox.Show("Connect to HID " + devicePathId + " device " + (i + 1) + " of " + deviceCollection.Count + " ?", "Multiple Wii Devices Found", MessageBoxButtons.YesNoCancel);
                        if (response == DialogResult.Cancel) return;
                        if (response == DialogResult.No) continue;
                    }

                    // Setup update handlers.

                    wiiDevice.WiimoteChanged          += wiiDevice_WiimoteChanged;
                    wiiDevice.WiimoteExtensionChanged += wiiDevice_WiimoteExtensionChanged;

                    // Connect and send a request to verify it worked.

                    wiiDevice.Connect();
                    wiiDevice.SetReportType(InputReport.IRAccel, false); // FALSE = DEVICE ONLY SENDS UPDATES WHEN VALUES CHANGE!
                    wiiDevice.SetLEDs(true, false, false, false);

                    // Enable processing of updates.

                    infoUpdateTimer.Enabled = true;

                    // Prevent connect being pressed more than once.

                    button_Connect.Enabled = false;
                    button_BluetoothAddDevice.Enabled = false;
                    zeroout.Enabled = true;

                    if (checkBox_AutoTare.Checked)
                        zeroout.PerformClick();

                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wiiDevice_WiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            // Called every time there is a sensor update, values available using e.WiimoteState.
            // Use this for tracking and filtering rapid accelerometer and gyroscope sensor data.
            // The balance board values are basic, so can be accessed directly only when needed.
        }

        private void wiiDevice_WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs e)
        {
            // This is not needed for balance boards.
        }

        void infoUpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Pass event onto the form GUI thread.

            this.BeginInvoke(new Action(() => InfoUpdate()));
        }

        private void InfoUpdate()
        {
            if (wiiDevice.WiimoteState.ExtensionType != ExtensionType.BalanceBoard)
            {
                label_Status.Text = "DEVICE IS NOT A BALANCE BOARD...";
                return;
            }

            // Get the current sensor KG values. (no temperature / latitude correction, can't set zero point properly.)

            var rwWeight      = wiiDevice.WiimoteState.BalanceBoardState.WeightKg;

            var rwTopLeft     = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopLeft;
            var rwTopRight    = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopRight;
            var rwBottomLeft  = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomLeft;
            var rwBottomRight = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomRight;
            var aButton       = wiiDevice.WiimoteState.ButtonState.A;

            // The alternative .SensorValuesRaw is meaningless in terms of actual weight. not adjusted with 0KG, 17KG and 34KG calibration data.
            
            //var rwTopLeft     = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesRaw.TopLeft     - wiiDevice.WiimoteState.BalanceBoardState.CalibrationInfo.Kg0.TopLeft;
            //var rwTopRight    = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesRaw.TopRight    - wiiDevice.WiimoteState.BalanceBoardState.CalibrationInfo.Kg0.TopRight;
            //var rwBottomLeft  = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesRaw.BottomLeft  - wiiDevice.WiimoteState.BalanceBoardState.CalibrationInfo.Kg0.BottomLeft;
            //var rwBottomRight = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesRaw.BottomRight - wiiDevice.WiimoteState.BalanceBoardState.CalibrationInfo.Kg0.BottomRight;

            // Show the sensor values in kg.
            label_rwWT.Text = rwWeight.ToString("0.000");
            label_rwTL.Text = rwTopLeft.ToString("0.000");
            label_rwTR.Text = rwTopRight.ToString("0.000");
            label_rwBL.Text = rwBottomLeft.ToString("0.000");
            label_rwBR.Text = rwBottomRight.ToString("0.000");

            // Prevent negative values by tracking lowest possible value and making it a zero based offset.

            if (rwWeight > 5)
            {
                button_SetCenterOffset.Enabled = true;
                button_SetCenterOffset.Text = "Set current balance as center";
                //toolTip1.SetToolTip(button_SetCenterOffset, "While standing or sitting on the balance board, click this button to set your current balance point as center");
            }
            else
            {
                if (resetCenterOffsetPossible)
                {
                    button_SetCenterOffset.Enabled = true;
                    button_SetCenterOffset.Text = "Reset Center Offset";
                    //toolTip1.SetToolTip(button_SetCenterOffset, "Revert back to the original center balance point, for the X/Y controlsl");
                }

                else
                {
                    button_SetCenterOffset.Text = "Set current balance as center";
                    button_SetCenterOffset.Enabled = false;
                }
            }

            if (rwTopLeft     < naCorners) naCorners = rwTopLeft;
            if (rwTopRight    < naCorners) naCorners = rwTopRight;
            if (rwBottomLeft  < naCorners) naCorners = rwBottomLeft;
            if (rwBottomRight < naCorners) naCorners = rwBottomRight;

            // Negative total weight is reset to zero as jumping or lifting the board causes negative spikes, which would break 'in use' checks.

            var owWeight      = rwWeight < 0f ? 0f : rwWeight;

            var owTopLeft     = rwTopLeft     -= naCorners;
            var owTopRight    = rwTopRight    -= naCorners;
            var owBottomLeft  = rwBottomLeft  -= naCorners;
            var owBottomRight = rwBottomRight -= naCorners;

            // Get offset that would make current values the center of mass.

            if (setCenterOffset)
            {
                setCenterOffset = false;
                resetCenterOffsetPossible = true;

                var rwHighest = Math.Max(Math.Max(rwTopLeft, rwTopRight), Math.Max(rwBottomLeft, rwBottomRight));

                oaTopLeft     = rwHighest - rwTopLeft;
                oaTopRight    = rwHighest - rwTopRight;
                oaBottomLeft  = rwHighest - rwBottomLeft;
                oaBottomRight = rwHighest - rwBottomRight;
            }

            // Keep values only when board is being used, otherwise offsets and small value jitters can trigger unwanted actions.

            if (owWeight > 5f)  // minimal weight of 5kg
            {
                owTopLeft     += oaTopLeft;
                owTopRight    += oaTopRight;
                owBottomLeft  += oaBottomLeft;
                owBottomRight += oaBottomRight;
            }
            else
            {
                owTopLeft     = 0;
                owTopRight    = 0;
                owBottomLeft  = 0;
                owBottomRight = 0;
            }
            
            label_owWT.Text = owWeight.ToString("0.000");
            label_owTL.Text = owTopLeft.ToString("0.000");   // + "\r\n" + oaTopLeft.ToString("0.000");
            label_owTR.Text = owTopRight.ToString("0.000"); // + "\r\n" + oaTopRight.ToString("0.000");
            label_owBL.Text = owBottomLeft.ToString("0.000");// + "\r\n" + oaBottomLeft.ToString("0.000");
            label_owBR.Text = owBottomRight.ToString("0.000");// + "\r\n" + oaBottomRight.ToString("0.000");

            // Calculate each weight ratio.

            var owrPercentage  = 100 / (rwTopLeft + rwTopRight + rwBottomLeft + rwBottomRight);
            var owrTopLeft     = owrPercentage * rwTopLeft;
            var owrTopRight    = owrPercentage * rwTopRight;
            var owrBottomLeft  = owrPercentage * rwBottomLeft;
            var owrBottomRight = owrPercentage * rwBottomRight;

            label_owrTL.Text = owrTopLeft.ToString("0.000");
            label_owrTR.Text = owrTopRight.ToString("0.000");
            label_owrBL.Text = owrBottomLeft.ToString("0.000");
            label_owrBR.Text = owrBottomRight.ToString("0.000");

            // Calculate balance ratio.

            var brX = owrBottomRight + owrTopRight;
            var brY = owrBottomRight + owrBottomLeft;

            label_brX.Text = brX.ToString("0.00");
            label_brY.Text = brY.ToString("0.00");

            // Diagonal ratio used for turning on the spot.

            var brDL = owrPercentage * (owBottomLeft + owTopRight);
            var brDR = owrPercentage * (owBottomRight + owTopLeft);
            var brDF = Math.Abs(brDL - brDR);

            label_brDL.Text = brDL.ToString("0.00");
            label_brDR.Text = brDR.ToString("0.00");
            label_brDF.Text = brDF.ToString("0.00");

            // Find the top-left of the cursor area, and use the balance ratio to get a position in pixels.

            int tlX = (int)((numericScreenWidth.Value - numericAreaWidth.Value) / 2);
            int tlY = (int)((numericScreenHeight.Value - numericAreaHeight.Value) / 2);

            int pX = (int)(brX * (float)numericAreaWidth.Value / 100) + tlX;
            int pY = (int)(brY * (float)numericAreaHeight.Value / 100) + tlY;

            // Update status message.

            label_Status.Text = pX.ToString() + ", " + pY.ToString();

            // IMPORTANT RESONITE STRING SHENANIGANS

            if (!checkBox_DisableActions.Checked)
            {
                // Convert all variables to Hex
                string rwTopLeftAsHex = BitConverter.ToUInt32(BitConverter.GetBytes(rwTopLeft), 0).ToString("X");
                string rwTopRightAsHex = BitConverter.ToUInt32(BitConverter.GetBytes(rwTopRight), 0).ToString("X");
                string rwBottomLeftAsHex = BitConverter.ToUInt32(BitConverter.GetBytes(rwBottomLeft), 0).ToString("X");
                string rwBottomRightAsHex = BitConverter.ToUInt32(BitConverter.GetBytes(rwBottomRight), 0).ToString("X");
                // And then sends them to Resonite
                string to_send = $"{rwTopLeftAsHex}{rwTopRightAsHex}{rwBottomLeftAsHex}{rwBottomRightAsHex}";

                /* All variables, some of which are discarded, and all using the old float string conversion.
                {rwWeight.ToString("0.000")}
                {rwTopLeft.ToString("0.000")}
                {rwTopRight.ToString("0.000")}
                {rwBottomLeft.ToString("0.000")}
                {rwBottomRight.ToString("0.000")}
                {owrTopLeft.ToString("0.000")}
                {owrTopRight.ToString("0.000")}
                {owrBottomLeft.ToString("0.000")}
                {owrBottomRight.ToString("0.000")}
                 */

                WebSocketComponent.SendMessage(to_send);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop updates.

            infoUpdateTimer.Enabled = false;
            wiiDevice.Disconnect();
        }

        private void zeroout_Click(object sender, EventArgs e)
        {
            wiiDevice.WiimoteState.BalanceBoardState.ZeroPoint.Reset = true;
            naCorners = 0f;
            oaTopLeft = 0f;
            oaTopRight = 0f;
            oaBottomLeft = 0f;
            oaBottomRight = 0f;
        }

        public void consoleBoxWriteLine(string line)
        {
            consoleBox.AppendText(line);
            consoleBox.AppendText(Environment.NewLine);
        }

        private void checkBox_DisableActions_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((CheckBox)sender).Checked;
            Properties.Settings.Default.DisableActions = isChecked;
            Properties.Settings.Default.Save();

            bool status;
            if (checkBox_DisableActions.Checked)
                status = false;
            else
                status = true;

            label_ScreenWidth.Enabled = status;
            label_ScreenHeight.Enabled = status;
            label_AreaWidth.Enabled = status;
            label_AreaHeight.Enabled = status;
        }

        private void ShowValues_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((CheckBox)sender).Checked;
            Properties.Settings.Default.ShowValuesInConsole = isChecked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_SendCGtoXY_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((CheckBox)sender).Checked;
            Properties.Settings.Default.SendCGtoXY = isChecked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_Send4LoadSensors_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((CheckBox)sender).Checked;
            Properties.Settings.Default.Send4LoadSensors = isChecked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_StartupAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((CheckBox)sender).Checked;
            Properties.Settings.Default.StartupAutoConnect = isChecked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_AutoTare_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((CheckBox)sender).Checked;
            Properties.Settings.Default.AutoTare = isChecked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_StartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((CheckBox)sender).Checked;
            Properties.Settings.Default.StartMinimized = isChecked;
            Properties.Settings.Default.Save();
        }

        private void numericScreenWidth_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ScreenWidth = (int)numericScreenWidth.Value;
            Properties.Settings.Default.Save();
        }

        private void numericScreenHeight_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ScreenHeight = (int)numericScreenHeight.Value;
            Properties.Settings.Default.Save();
        }

        private void numericAreaWidth_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AreaWidth = (int)numericAreaWidth.Value;
            Properties.Settings.Default.Save();
        }

        private void numericAreaHeight_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AreaHeight = (int)numericAreaHeight.Value;
            Properties.Settings.Default.Save();
        }

        private void label_rwTL_Click(object sender, EventArgs e)
        {

        }
    }
}
