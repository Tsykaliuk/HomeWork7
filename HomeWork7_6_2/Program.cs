using Facade;

var amplifier = new Amplifier();
var dvdPlayer = new DvdPlayer();
var projector = new Projector();
var lightingSystem = new LightingSystem();

var homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector, lightingSystem);

homeTheater.StartMovieExperience("Interstellar");
Console.WriteLine();
homeTheater.EndMovieExperience();
