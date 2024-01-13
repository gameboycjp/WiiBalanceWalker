# KarIO.FitBoard v1 - by gamethecupdog
# Modification of WiiBalanceWalker v0.5 - by Shachar Liberman - modified by ewio

# gamethecupdog's changes
	o Removed absolute cursor movement, replaced with list of variables sent over websocket in text format
	o Added CytraX Websocket implementation, [CytraX.WS.cs](https://github.com/RaithSphere/VR-Stuff/blob/main/HRM-Windows/HeartRate/CytraX.WS.cs)

# ewio's changes
	o Removed actions system, replaced with absolute cursor movement
	o Removed vJoy as it was not needed

## WiiBalanceWalker v0.4 and before - Released by Richard Perry from GreyCube.com - Under the Microsoft Public License.
 
[Uses lshachar's WiimoteLib DLL  ](https://github.com/lshachar/WiimoteLib)<br/>
[Uses the 32Feet.NET bluetooth DLL](http://32feet.codeplex.com)<br/>
[Uses vJoy device driver (by Shaul Eizikovich)]( http://vjoystick.sourceforge.net/)<br/>
(Previous to  v0.5 [VJoy by headsoft](http://headsoft.com.au/index.php?category=vjoy) was used)<br/>
***

### WiiBalanceWalker v0.5 progress over v0.4:
	o Virtual joystick Support for x64 systems
	o Can send values directly measured from each of the load sensors, to the virtual joystick interface.
	o Instructions for adding / removing bluetooth devices updated for windows 10. 
	o Easier to make permanent connections with the balance board by using permanent PIN code
	o New startup options makes usage even easier
	o New option to tare the balance board (makes all current measurments zero. use this button while you're off the balance board)
	o Measured values are now in real kilograms (previously they were 4 times too large)
	o Added some helpful tooltips, try to hover your mouse over things to get some explanations.

Get your compiled archive in the [Releases section](https://github.com/lshachar/Wiibalancewalker/releases)<br/>
For virtual joystick support, [install vJoy by Shaul Eizikovich](http://vjoystick.sourceforge.net/site/index.php/download-a-install/download)<br/>
Feel free to [put some bread in my jar](https://paypal.me/lshachar?locale.x=en_US), only if you feel like it!

### CytraX.WS.cs is licensed under MIT, everything else is MS-PL
