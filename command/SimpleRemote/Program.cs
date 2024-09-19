using SimpleRemote.Commands;
using SimpleRemote.Invokers;
using SimpleRemote.Receivers;

var remote = new SimpleRemoteControl();

var light = new Light();
var garageDoor = new GarageDoor();

var lightOn = new LightOnCommand(light);
var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

remote.SetCommand(lightOn);
remote.ButtonWasPressed();

remote.SetCommand(garageDoorOpenCommand);
remote.ButtonWasPressed();
