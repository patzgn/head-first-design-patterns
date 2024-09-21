using HomeTheater.Facades;
using HomeTheater.Subsystem;

var amp = new Amplifier("Amplifier");
var tuner = new Tuner("AM/FM Tuner", amp);
var player = new StreamingPlayer("Streaming Player", amp);
var cd = new CdPlayer("CD Player", amp);
var projector = new Projector("Projector", player);
var lights = new TheaterLights("Theater Ceiling Lights");
var screen = new Screen("Theater Screen");
var popper = new PopcornPopper("Popcorn Popper");

var homeTheater = new HomeTheaterFacade(amp, tuner, player, cd, projector, lights, screen, popper);

homeTheater.WatchMovie("Raiders of the Lost Ark");
homeTheater.EndMovie();
