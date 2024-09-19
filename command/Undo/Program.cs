using Undo.Commands;
using Undo.Invokers;
using Undo.Receivers;

var remoteControl = new RemoteControlWithUndo();

var livingRoomLight = new Light("Living Room");

var livingRoomLightOn = new LightOnCommand(livingRoomLight);
var livingRoomLightOff = new LightOffCommand(livingRoomLight);

remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

remoteControl.OnButtonWasPushed(0);
remoteControl.OffButtonWasPushed(0);
Console.WriteLine(remoteControl);
remoteControl.UndoButtonWasPushed();
remoteControl.OffButtonWasPushed(0);
remoteControl.OnButtonWasPushed(0);
Console.WriteLine(remoteControl);
remoteControl.UndoButtonWasPushed();

var ceilingFan = new CeilingFan("Living Room");

var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

remoteControl.OnButtonWasPushed(0);
remoteControl.OffButtonWasPushed(0);
Console.WriteLine(remoteControl);
remoteControl.UndoButtonWasPushed();

remoteControl.OnButtonWasPushed(1);
Console.WriteLine(remoteControl);
remoteControl.UndoButtonWasPushed();
