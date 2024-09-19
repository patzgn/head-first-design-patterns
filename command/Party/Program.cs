using Party.Commands;
using Party.Invokers;
using Party.Receivers;

var remoteControl = new RemoteControl();

var light = new Light("Living Room");
var stereo = new Stereo("Living Room");
var tv = new TV("Living Room");
var hottub = new Hottub();

var lightOn = new LightOnCommand(light);
var stereoOn = new StereoOnCommand(stereo);
var tvOn = new TVOnCommand(tv);
var hottubOn = new HottubOnCommand(hottub);

var lightOff = new LightOffCommand(light);
var stereoOff = new StereoOffCommand(stereo);
var tvOff = new TVOffCommand(tv);
var hottubOff = new HottubOffCommand(hottub);

ICommand[] partyOn = [lightOn, stereoOn, tvOn, hottubOn];
ICommand[] partyOff = [lightOff, stereoOff, tvOff, hottubOff];

MacroCommand partyOnMacro = new MacroCommand(partyOn);
MacroCommand partyOffMacro = new MacroCommand(partyOff);

remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

Console.WriteLine(remoteControl);
Console.WriteLine("--- Pushing Macro On---");
remoteControl.OnButtonWasPushed(0);
Console.WriteLine("--- Pushing Macro Off---");
remoteControl.OffButtonWasPushed(0);
