using Remote.Commands;
using Remote.Invokers;
using Remote.Receivers;

var remoteControl = new RemoteControl();

var livingRoomLight = new Light("Living Room");
var kitchenLight = new Light("Kitchen");
var ceilingFan = new CeilingFan("Living Room");
var garageDoor = new GarageDoor("Garage");
var stereo = new Stereo("Living Room");

var livingRoomLightOn = new LightOnCommand(livingRoomLight);
var livingRoomLightOff = new LightOffCommand(livingRoomLight);

var kitchenLightOn = new LightOnCommand(kitchenLight);
var kitchenLightOff = new LightOffCommand(kitchenLight);

var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

var garageDoorUp = new GarageDoorUpCommand(garageDoor);
var garageDoorDown = new GarageDoorDownCommand(garageDoor);

var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
var stereoOff = new StereoOffCommand(stereo);

remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
remoteControl.SetCommand(3, garageDoorUp, garageDoorDown);
remoteControl.SetCommand(4, stereoOnWithCD, stereoOff);

Console.WriteLine(remoteControl);

remoteControl.OnButtonWasPushed(0);
remoteControl.OffButtonWasPushed(0);
remoteControl.OnButtonWasPushed(1);
remoteControl.OffButtonWasPushed(1);
remoteControl.OnButtonWasPushed(2);
remoteControl.OffButtonWasPushed(2);
remoteControl.OnButtonWasPushed(3);
remoteControl.OffButtonWasPushed(3);
remoteControl.OnButtonWasPushed(4);
remoteControl.OffButtonWasPushed(4);