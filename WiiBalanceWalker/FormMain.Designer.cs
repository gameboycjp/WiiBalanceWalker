namespace WiiBalanceWalker
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_rwWT = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_brX = new System.Windows.Forms.Label();
            this.label_brY = new System.Windows.Forms.Label();
            this.label_brDL = new System.Windows.Forms.Label();
            this.label_brDR = new System.Windows.Forms.Label();
            this.groupBox_RawWeight = new System.Windows.Forms.GroupBox();
            this.label_rwBR = new System.Windows.Forms.Label();
            this.label_rwBL = new System.Windows.Forms.Label();
            this.label_rwTR = new System.Windows.Forms.Label();
            this.label_rwTL = new System.Windows.Forms.Label();
            this.groupBox_OffsetWeight = new System.Windows.Forms.GroupBox();
            this.label_owWT = new System.Windows.Forms.Label();
            this.label_owTL = new System.Windows.Forms.Label();
            this.label_owTR = new System.Windows.Forms.Label();
            this.label_owBL = new System.Windows.Forms.Label();
            this.label_owBR = new System.Windows.Forms.Label();
            this.groupBox_OffsetWeightRatio = new System.Windows.Forms.GroupBox();
            this.label_owrTL = new System.Windows.Forms.Label();
            this.label_owrTR = new System.Windows.Forms.Label();
            this.label_owrBL = new System.Windows.Forms.Label();
            this.label_owrBR = new System.Windows.Forms.Label();
            this.groupBox_General = new System.Windows.Forms.GroupBox();
            this.zeroout = new System.Windows.Forms.Button();
            this.button_SetCenterOffset = new System.Windows.Forms.Button();
            this.button_ResetDefaults = new System.Windows.Forms.Button();
            this.button_BluetoothAddDevice = new System.Windows.Forms.Button();
            this.groupBox_BalanceRatio = new System.Windows.Forms.GroupBox();
            this.label_brDF = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.groupBox_Actions = new System.Windows.Forms.GroupBox();
            this.label_AreaHeight = new System.Windows.Forms.Label();
            this.label_AreaWidth = new System.Windows.Forms.Label();
            this.numericAreaHeight = new System.Windows.Forms.NumericUpDown();
            this.numericAreaWidth = new System.Windows.Forms.NumericUpDown();
            this.checkBox_DisableActions = new System.Windows.Forms.CheckBox();
            this.label_ScreenHeight = new System.Windows.Forms.Label();
            this.label_ScreenWidth = new System.Windows.Forms.Label();
            this.numericScreenHeight = new System.Windows.Forms.NumericUpDown();
            this.numericScreenWidth = new System.Windows.Forms.NumericUpDown();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_StartupAutoConnect = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startupOptions = new System.Windows.Forms.GroupBox();
            this.checkBox_StartMinimized = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoTare = new System.Windows.Forms.CheckBox();
            this.groupBox_RawWeight.SuspendLayout();
            this.groupBox_OffsetWeight.SuspendLayout();
            this.groupBox_OffsetWeightRatio.SuspendLayout();
            this.groupBox_General.SuspendLayout();
            this.groupBox_BalanceRatio.SuspendLayout();
            this.groupBox_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAreaHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAreaWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScreenHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScreenWidth)).BeginInit();
            this.startupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_rwWT
            // 
            this.label_rwWT.AutoSize = true;
            this.label_rwWT.Location = new System.Drawing.Point(63, 113);
            this.label_rwWT.Name = "label_rwWT";
            this.label_rwWT.Size = new System.Drawing.Size(25, 13);
            this.label_rwWT.TabIndex = 0;
            this.label_rwWT.Text = "WT";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(174, 82);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(183, 48);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect to Wii Balance Board";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_brX
            // 
            this.label_brX.AutoSize = true;
            this.label_brX.Location = new System.Drawing.Point(25, 32);
            this.label_brX.Name = "label_brX";
            this.label_brX.Size = new System.Drawing.Size(14, 13);
            this.label_brX.TabIndex = 0;
            this.label_brX.Text = "X";
            // 
            // label_brY
            // 
            this.label_brY.AutoSize = true;
            this.label_brY.Location = new System.Drawing.Point(101, 32);
            this.label_brY.Name = "label_brY";
            this.label_brY.Size = new System.Drawing.Size(14, 13);
            this.label_brY.TabIndex = 0;
            this.label_brY.Text = "Y";
            // 
            // label_brDL
            // 
            this.label_brDL.AutoSize = true;
            this.label_brDL.Location = new System.Drawing.Point(25, 76);
            this.label_brDL.Name = "label_brDL";
            this.label_brDL.Size = new System.Drawing.Size(21, 13);
            this.label_brDL.TabIndex = 0;
            this.label_brDL.Text = "DL";
            // 
            // label_brDR
            // 
            this.label_brDR.AutoSize = true;
            this.label_brDR.Location = new System.Drawing.Point(101, 76);
            this.label_brDR.Name = "label_brDR";
            this.label_brDR.Size = new System.Drawing.Size(23, 13);
            this.label_brDR.TabIndex = 0;
            this.label_brDR.Text = "DR";
            // 
            // groupBox_RawWeight
            // 
            this.groupBox_RawWeight.Controls.Add(this.label_rwBR);
            this.groupBox_RawWeight.Controls.Add(this.label_rwBL);
            this.groupBox_RawWeight.Controls.Add(this.label_rwTR);
            this.groupBox_RawWeight.Controls.Add(this.label_rwTL);
            this.groupBox_RawWeight.Controls.Add(this.label_rwWT);
            this.groupBox_RawWeight.Location = new System.Drawing.Point(12, 12);
            this.groupBox_RawWeight.Name = "groupBox_RawWeight";
            this.groupBox_RawWeight.Size = new System.Drawing.Size(150, 139);
            this.groupBox_RawWeight.TabIndex = 3;
            this.groupBox_RawWeight.TabStop = false;
            this.groupBox_RawWeight.Text = "Raw Weight ";
            // 
            // label_rwBR
            // 
            this.label_rwBR.AutoSize = true;
            this.label_rwBR.Location = new System.Drawing.Point(101, 76);
            this.label_rwBR.Name = "label_rwBR";
            this.label_rwBR.Size = new System.Drawing.Size(22, 13);
            this.label_rwBR.TabIndex = 0;
            this.label_rwBR.Text = "BR";
            // 
            // label_rwBL
            // 
            this.label_rwBL.AutoSize = true;
            this.label_rwBL.Location = new System.Drawing.Point(25, 76);
            this.label_rwBL.Name = "label_rwBL";
            this.label_rwBL.Size = new System.Drawing.Size(20, 13);
            this.label_rwBL.TabIndex = 0;
            this.label_rwBL.Text = "BL";
            // 
            // label_rwTR
            // 
            this.label_rwTR.AutoSize = true;
            this.label_rwTR.Location = new System.Drawing.Point(101, 32);
            this.label_rwTR.Name = "label_rwTR";
            this.label_rwTR.Size = new System.Drawing.Size(22, 13);
            this.label_rwTR.TabIndex = 0;
            this.label_rwTR.Text = "TR";
            // 
            // label_rwTL
            // 
            this.label_rwTL.AutoSize = true;
            this.label_rwTL.Location = new System.Drawing.Point(25, 32);
            this.label_rwTL.Name = "label_rwTL";
            this.label_rwTL.Size = new System.Drawing.Size(20, 13);
            this.label_rwTL.TabIndex = 0;
            this.label_rwTL.Text = "TL";
            this.label_rwTL.Click += new System.EventHandler(this.label_rwTL_Click);
            // 
            // groupBox_OffsetWeight
            // 
            this.groupBox_OffsetWeight.Controls.Add(this.label_owWT);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owTL);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owTR);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owBL);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owBR);
            this.groupBox_OffsetWeight.Location = new System.Drawing.Point(168, 12);
            this.groupBox_OffsetWeight.Name = "groupBox_OffsetWeight";
            this.groupBox_OffsetWeight.Size = new System.Drawing.Size(150, 139);
            this.groupBox_OffsetWeight.TabIndex = 4;
            this.groupBox_OffsetWeight.TabStop = false;
            this.groupBox_OffsetWeight.Text = "Offset Weight";
            // 
            // label_owWT
            // 
            this.label_owWT.AutoSize = true;
            this.label_owWT.Location = new System.Drawing.Point(63, 113);
            this.label_owWT.Name = "label_owWT";
            this.label_owWT.Size = new System.Drawing.Size(25, 13);
            this.label_owWT.TabIndex = 1;
            this.label_owWT.Text = "WT";
            // 
            // label_owTL
            // 
            this.label_owTL.AutoSize = true;
            this.label_owTL.Location = new System.Drawing.Point(25, 32);
            this.label_owTL.Name = "label_owTL";
            this.label_owTL.Size = new System.Drawing.Size(20, 13);
            this.label_owTL.TabIndex = 0;
            this.label_owTL.Text = "TL";
            // 
            // label_owTR
            // 
            this.label_owTR.AutoSize = true;
            this.label_owTR.Location = new System.Drawing.Point(101, 32);
            this.label_owTR.Name = "label_owTR";
            this.label_owTR.Size = new System.Drawing.Size(22, 13);
            this.label_owTR.TabIndex = 0;
            this.label_owTR.Text = "TR";
            // 
            // label_owBL
            // 
            this.label_owBL.AutoSize = true;
            this.label_owBL.Location = new System.Drawing.Point(25, 76);
            this.label_owBL.Name = "label_owBL";
            this.label_owBL.Size = new System.Drawing.Size(20, 13);
            this.label_owBL.TabIndex = 0;
            this.label_owBL.Text = "BL";
            // 
            // label_owBR
            // 
            this.label_owBR.AutoSize = true;
            this.label_owBR.Location = new System.Drawing.Point(101, 76);
            this.label_owBR.Name = "label_owBR";
            this.label_owBR.Size = new System.Drawing.Size(22, 13);
            this.label_owBR.TabIndex = 0;
            this.label_owBR.Text = "BR";
            // 
            // groupBox_OffsetWeightRatio
            // 
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrTL);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrTR);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrBL);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrBR);
            this.groupBox_OffsetWeightRatio.Location = new System.Drawing.Point(324, 12);
            this.groupBox_OffsetWeightRatio.Name = "groupBox_OffsetWeightRatio";
            this.groupBox_OffsetWeightRatio.Size = new System.Drawing.Size(150, 139);
            this.groupBox_OffsetWeightRatio.TabIndex = 4;
            this.groupBox_OffsetWeightRatio.TabStop = false;
            this.groupBox_OffsetWeightRatio.Text = "Offset Weight Ratio";
            // 
            // label_owrTL
            // 
            this.label_owrTL.AutoSize = true;
            this.label_owrTL.Location = new System.Drawing.Point(25, 32);
            this.label_owrTL.Name = "label_owrTL";
            this.label_owrTL.Size = new System.Drawing.Size(20, 13);
            this.label_owrTL.TabIndex = 0;
            this.label_owrTL.Text = "TL";
            // 
            // label_owrTR
            // 
            this.label_owrTR.AutoSize = true;
            this.label_owrTR.Location = new System.Drawing.Point(101, 32);
            this.label_owrTR.Name = "label_owrTR";
            this.label_owrTR.Size = new System.Drawing.Size(22, 13);
            this.label_owrTR.TabIndex = 0;
            this.label_owrTR.Text = "TR";
            // 
            // label_owrBL
            // 
            this.label_owrBL.AutoSize = true;
            this.label_owrBL.Location = new System.Drawing.Point(25, 76);
            this.label_owrBL.Name = "label_owrBL";
            this.label_owrBL.Size = new System.Drawing.Size(20, 13);
            this.label_owrBL.TabIndex = 0;
            this.label_owrBL.Text = "BL";
            // 
            // label_owrBR
            // 
            this.label_owrBR.AutoSize = true;
            this.label_owrBR.Location = new System.Drawing.Point(101, 76);
            this.label_owrBR.Name = "label_owrBR";
            this.label_owrBR.Size = new System.Drawing.Size(22, 13);
            this.label_owrBR.TabIndex = 0;
            this.label_owrBR.Text = "BR";
            // 
            // groupBox_General
            // 
            this.groupBox_General.Controls.Add(this.zeroout);
            this.groupBox_General.Controls.Add(this.button_SetCenterOffset);
            this.groupBox_General.Controls.Add(this.button_ResetDefaults);
            this.groupBox_General.Controls.Add(this.button_BluetoothAddDevice);
            this.groupBox_General.Controls.Add(this.button_Connect);
            this.groupBox_General.Location = new System.Drawing.Point(12, 157);
            this.groupBox_General.Name = "groupBox_General";
            this.groupBox_General.Size = new System.Drawing.Size(373, 136);
            this.groupBox_General.TabIndex = 0;
            this.groupBox_General.TabStop = false;
            this.groupBox_General.Text = "General";
            // 
            // zeroout
            // 
            this.zeroout.Enabled = false;
            this.zeroout.Location = new System.Drawing.Point(15, 28);
            this.zeroout.Name = "zeroout";
            this.zeroout.Size = new System.Drawing.Size(138, 26);
            this.zeroout.TabIndex = 7;
            this.zeroout.Text = "Tare Balance Board";
            this.toolTip1.SetToolTip(this.zeroout, "Press this button while no weight is on the balance board, to reset all current r" +
        "aw weight values to zero");
            this.zeroout.UseVisualStyleBackColor = true;
            this.zeroout.Click += new System.EventHandler(this.zeroout_Click);
            // 
            // button_SetCenterOffset
            // 
            this.button_SetCenterOffset.Enabled = false;
            this.button_SetCenterOffset.Location = new System.Drawing.Point(15, 59);
            this.button_SetCenterOffset.Name = "button_SetCenterOffset";
            this.button_SetCenterOffset.Size = new System.Drawing.Size(138, 34);
            this.button_SetCenterOffset.TabIndex = 2;
            this.button_SetCenterOffset.Text = "Set current balance as center";
            this.toolTip1.SetToolTip(this.button_SetCenterOffset, "While standing or sitting on the balance board, click this button to set your cur" +
        "rent balance point as center");
            this.button_SetCenterOffset.UseVisualStyleBackColor = true;
            this.button_SetCenterOffset.Click += new System.EventHandler(this.button_SetCenterOffset_Click);
            // 
            // button_ResetDefaults
            // 
            this.button_ResetDefaults.Location = new System.Drawing.Point(15, 96);
            this.button_ResetDefaults.Name = "button_ResetDefaults";
            this.button_ResetDefaults.Size = new System.Drawing.Size(138, 34);
            this.button_ResetDefaults.TabIndex = 3;
            this.button_ResetDefaults.Text = "Load default settings and exit";
            this.button_ResetDefaults.UseVisualStyleBackColor = true;
            this.button_ResetDefaults.Click += new System.EventHandler(this.button_ResetDefaults_Click);
            // 
            // button_BluetoothAddDevice
            // 
            this.button_BluetoothAddDevice.Location = new System.Drawing.Point(174, 29);
            this.button_BluetoothAddDevice.Name = "button_BluetoothAddDevice";
            this.button_BluetoothAddDevice.Size = new System.Drawing.Size(183, 46);
            this.button_BluetoothAddDevice.TabIndex = 1;
            this.button_BluetoothAddDevice.Text = "Add/Remove bluetooth Wii device";
            this.button_BluetoothAddDevice.UseVisualStyleBackColor = true;
            this.button_BluetoothAddDevice.Click += new System.EventHandler(this.button_BluetoothAddDevice_Click);
            // 
            // groupBox_BalanceRatio
            // 
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDF);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brX);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDR);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDL);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brY);
            this.groupBox_BalanceRatio.Location = new System.Drawing.Point(480, 12);
            this.groupBox_BalanceRatio.Name = "groupBox_BalanceRatio";
            this.groupBox_BalanceRatio.Size = new System.Drawing.Size(150, 139);
            this.groupBox_BalanceRatio.TabIndex = 5;
            this.groupBox_BalanceRatio.TabStop = false;
            this.groupBox_BalanceRatio.Text = "Balance Ratio";
            // 
            // label_brDF
            // 
            this.label_brDF.AutoSize = true;
            this.label_brDF.Location = new System.Drawing.Point(65, 113);
            this.label_brDF.Name = "label_brDF";
            this.label_brDF.Size = new System.Drawing.Size(21, 13);
            this.label_brDF.TabIndex = 0;
            this.label_brDF.Text = "DF";
            // 
            // label_Status
            // 
            this.label_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Status.Location = new System.Drawing.Point(12, 296);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(618, 24);
            this.label_Status.TabIndex = 4;
            this.label_Status.Text = "STATUS";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_Actions
            // 
            this.groupBox_Actions.Controls.Add(this.label_AreaHeight);
            this.groupBox_Actions.Controls.Add(this.label_AreaWidth);
            this.groupBox_Actions.Controls.Add(this.numericAreaHeight);
            this.groupBox_Actions.Controls.Add(this.numericAreaWidth);
            this.groupBox_Actions.Controls.Add(this.checkBox_DisableActions);
            this.groupBox_Actions.Controls.Add(this.label_ScreenHeight);
            this.groupBox_Actions.Controls.Add(this.label_ScreenWidth);
            this.groupBox_Actions.Controls.Add(this.numericScreenHeight);
            this.groupBox_Actions.Controls.Add(this.numericScreenWidth);
            this.groupBox_Actions.Location = new System.Drawing.Point(636, 12);
            this.groupBox_Actions.Name = "groupBox_Actions";
            this.groupBox_Actions.Size = new System.Drawing.Size(296, 199);
            this.groupBox_Actions.TabIndex = 2;
            this.groupBox_Actions.TabStop = false;
            this.groupBox_Actions.Text = "Actions";
            // 
            // label_AreaHeight
            // 
            this.label_AreaHeight.AutoSize = true;
            this.label_AreaHeight.Location = new System.Drawing.Point(15, 126);
            this.label_AreaHeight.Name = "label_AreaHeight";
            this.label_AreaHeight.Size = new System.Drawing.Size(96, 13);
            this.label_AreaHeight.TabIndex = 6;
            this.label_AreaHeight.Text = "Cursor Area Height";
            // 
            // label_AreaWidth
            // 
            this.label_AreaWidth.AutoSize = true;
            this.label_AreaWidth.Location = new System.Drawing.Point(15, 99);
            this.label_AreaWidth.Name = "label_AreaWidth";
            this.label_AreaWidth.Size = new System.Drawing.Size(93, 13);
            this.label_AreaWidth.TabIndex = 7;
            this.label_AreaWidth.Text = "Cursor Area Width";
            // 
            // numericAreaHeight
            // 
            this.numericAreaHeight.Location = new System.Drawing.Point(145, 123);
            this.numericAreaHeight.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericAreaHeight.Name = "numericAreaHeight";
            this.numericAreaHeight.Size = new System.Drawing.Size(139, 20);
            this.numericAreaHeight.TabIndex = 9;
            this.numericAreaHeight.ValueChanged += new System.EventHandler(this.numericAreaHeight_ValueChanged);
            // 
            // numericAreaWidth
            // 
            this.numericAreaWidth.Location = new System.Drawing.Point(145, 96);
            this.numericAreaWidth.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericAreaWidth.Name = "numericAreaWidth";
            this.numericAreaWidth.Size = new System.Drawing.Size(139, 20);
            this.numericAreaWidth.TabIndex = 8;
            this.numericAreaWidth.ValueChanged += new System.EventHandler(this.numericAreaWidth_ValueChanged);
            // 
            // checkBox_DisableActions
            // 
            this.checkBox_DisableActions.AutoSize = true;
            this.checkBox_DisableActions.Location = new System.Drawing.Point(18, 164);
            this.checkBox_DisableActions.Name = "checkBox_DisableActions";
            this.checkBox_DisableActions.Size = new System.Drawing.Size(113, 17);
            this.checkBox_DisableActions.TabIndex = 0;
            this.checkBox_DisableActions.Text = "Disable All Actions";
            this.checkBox_DisableActions.UseVisualStyleBackColor = true;
            this.checkBox_DisableActions.CheckedChanged += new System.EventHandler(this.checkBox_DisableActions_CheckedChanged);
            // 
            // label_ScreenHeight
            // 
            this.label_ScreenHeight.AutoSize = true;
            this.label_ScreenHeight.Location = new System.Drawing.Point(15, 56);
            this.label_ScreenHeight.Name = "label_ScreenHeight";
            this.label_ScreenHeight.Size = new System.Drawing.Size(75, 13);
            this.label_ScreenHeight.TabIndex = 0;
            this.label_ScreenHeight.Text = "Screen Height";
            // 
            // label_ScreenWidth
            // 
            this.label_ScreenWidth.AutoSize = true;
            this.label_ScreenWidth.Location = new System.Drawing.Point(15, 29);
            this.label_ScreenWidth.Name = "label_ScreenWidth";
            this.label_ScreenWidth.Size = new System.Drawing.Size(72, 13);
            this.label_ScreenWidth.TabIndex = 0;
            this.label_ScreenWidth.Text = "Screen Width";
            // 
            // numericScreenHeight
            // 
            this.numericScreenHeight.Location = new System.Drawing.Point(145, 53);
            this.numericScreenHeight.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericScreenHeight.Name = "numericScreenHeight";
            this.numericScreenHeight.Size = new System.Drawing.Size(139, 20);
            this.numericScreenHeight.TabIndex = 5;
            this.numericScreenHeight.ValueChanged += new System.EventHandler(this.numericScreenHeight_ValueChanged);
            // 
            // numericScreenWidth
            // 
            this.numericScreenWidth.Location = new System.Drawing.Point(145, 26);
            this.numericScreenWidth.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericScreenWidth.Name = "numericScreenWidth";
            this.numericScreenWidth.Size = new System.Drawing.Size(139, 20);
            this.numericScreenWidth.TabIndex = 3;
            this.numericScreenWidth.ValueChanged += new System.EventHandler(this.numericScreenWidth_ValueChanged);
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(636, 216);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(296, 104);
            this.consoleBox.TabIndex = 7;
            this.consoleBox.Text = "vJoy Console";
            // 
            // checkBox_StartupAutoConnect
            // 
            this.checkBox_StartupAutoConnect.AutoSize = true;
            this.checkBox_StartupAutoConnect.Location = new System.Drawing.Point(6, 19);
            this.checkBox_StartupAutoConnect.Name = "checkBox_StartupAutoConnect";
            this.checkBox_StartupAutoConnect.Size = new System.Drawing.Size(201, 17);
            this.checkBox_StartupAutoConnect.TabIndex = 0;
            this.checkBox_StartupAutoConnect.Text = "Connect to Balance Board on startup";
            this.toolTip1.SetToolTip(this.checkBox_StartupAutoConnect, "To save you from clicking \'Connect to Wii Balance Board\' each time you launch Wii" +
        " Balance Walker");
            this.checkBox_StartupAutoConnect.UseVisualStyleBackColor = true;
            this.checkBox_StartupAutoConnect.CheckedChanged += new System.EventHandler(this.checkBox_StartupAutoConnect_CheckedChanged);
            // 
            // startupOptions
            // 
            this.startupOptions.Controls.Add(this.checkBox_StartMinimized);
            this.startupOptions.Controls.Add(this.checkBox_AutoTare);
            this.startupOptions.Controls.Add(this.checkBox_StartupAutoConnect);
            this.startupOptions.Location = new System.Drawing.Point(392, 157);
            this.startupOptions.Name = "startupOptions";
            this.startupOptions.Size = new System.Drawing.Size(238, 136);
            this.startupOptions.TabIndex = 12;
            this.startupOptions.TabStop = false;
            this.startupOptions.Text = "Startup Options";
            // 
            // checkBox_StartMinimized
            // 
            this.checkBox_StartMinimized.AutoSize = true;
            this.checkBox_StartMinimized.Location = new System.Drawing.Point(6, 65);
            this.checkBox_StartMinimized.Name = "checkBox_StartMinimized";
            this.checkBox_StartMinimized.Size = new System.Drawing.Size(139, 17);
            this.checkBox_StartMinimized.TabIndex = 2;
            this.checkBox_StartMinimized.Text = "Start Program Minimized";
            this.checkBox_StartMinimized.UseVisualStyleBackColor = true;
            this.checkBox_StartMinimized.CheckedChanged += new System.EventHandler(this.checkBox_StartMinimized_CheckedChanged);
            // 
            // checkBox_AutoTare
            // 
            this.checkBox_AutoTare.AutoSize = true;
            this.checkBox_AutoTare.Location = new System.Drawing.Point(6, 42);
            this.checkBox_AutoTare.Name = "checkBox_AutoTare";
            this.checkBox_AutoTare.Size = new System.Drawing.Size(201, 17);
            this.checkBox_AutoTare.TabIndex = 1;
            this.checkBox_AutoTare.Text = "Tare Balance Board after connection";
            this.checkBox_AutoTare.UseVisualStyleBackColor = true;
            this.checkBox_AutoTare.CheckedChanged += new System.EventHandler(this.checkBox_AutoTare_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 338);
            this.Controls.Add(this.startupOptions);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.groupBox_Actions);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.groupBox_BalanceRatio);
            this.Controls.Add(this.groupBox_General);
            this.Controls.Add(this.groupBox_OffsetWeightRatio);
            this.Controls.Add(this.groupBox_OffsetWeight);
            this.Controls.Add(this.groupBox_RawWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wii Balance Walker - Version 0.5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_RawWeight.ResumeLayout(false);
            this.groupBox_RawWeight.PerformLayout();
            this.groupBox_OffsetWeight.ResumeLayout(false);
            this.groupBox_OffsetWeight.PerformLayout();
            this.groupBox_OffsetWeightRatio.ResumeLayout(false);
            this.groupBox_OffsetWeightRatio.PerformLayout();
            this.groupBox_General.ResumeLayout(false);
            this.groupBox_BalanceRatio.ResumeLayout(false);
            this.groupBox_BalanceRatio.PerformLayout();
            this.groupBox_Actions.ResumeLayout(false);
            this.groupBox_Actions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAreaHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAreaWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScreenHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScreenWidth)).EndInit();
            this.startupOptions.ResumeLayout(false);
            this.startupOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_rwWT;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_brX;
        private System.Windows.Forms.Label label_brY;
        private System.Windows.Forms.Label label_brDL;
        private System.Windows.Forms.Label label_brDR;
        private System.Windows.Forms.GroupBox groupBox_RawWeight;
        private System.Windows.Forms.Label label_rwBR;
        private System.Windows.Forms.Label label_rwBL;
        private System.Windows.Forms.Label label_rwTR;
        private System.Windows.Forms.Label label_rwTL;
        private System.Windows.Forms.GroupBox groupBox_OffsetWeight;
        private System.Windows.Forms.GroupBox groupBox_OffsetWeightRatio;
        private System.Windows.Forms.Label label_owTL;
        private System.Windows.Forms.Label label_owTR;
        private System.Windows.Forms.Label label_owBL;
        private System.Windows.Forms.Label label_owBR;
        private System.Windows.Forms.Label label_owrTL;
        private System.Windows.Forms.Label label_owrTR;
        private System.Windows.Forms.Label label_owrBL;
        private System.Windows.Forms.Label label_owrBR;
        private System.Windows.Forms.GroupBox groupBox_General;
        private System.Windows.Forms.GroupBox groupBox_BalanceRatio;
        private System.Windows.Forms.Label label_brDF;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_BluetoothAddDevice;
        private System.Windows.Forms.GroupBox groupBox_Actions;
        private System.Windows.Forms.Button button_SetCenterOffset;
        private System.Windows.Forms.Button button_ResetDefaults;
        private System.Windows.Forms.CheckBox checkBox_DisableActions;
        private System.Windows.Forms.Label label_owWT;
        private System.Windows.Forms.Button zeroout;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox startupOptions;
        private System.Windows.Forms.CheckBox checkBox_StartupAutoConnect;
        private System.Windows.Forms.CheckBox checkBox_AutoTare;
        private System.Windows.Forms.CheckBox checkBox_StartMinimized;
        private System.Windows.Forms.Label label_ScreenHeight;
        private System.Windows.Forms.Label label_ScreenWidth;
        private System.Windows.Forms.NumericUpDown numericScreenHeight;
        private System.Windows.Forms.NumericUpDown numericScreenWidth;
        private System.Windows.Forms.Label label_AreaHeight;
        private System.Windows.Forms.Label label_AreaWidth;
        private System.Windows.Forms.NumericUpDown numericAreaHeight;
        private System.Windows.Forms.NumericUpDown numericAreaWidth;
    }
}

