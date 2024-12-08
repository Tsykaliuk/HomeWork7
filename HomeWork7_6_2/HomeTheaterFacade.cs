namespace Facade;

public class HomeTheaterFacade
{
    private readonly Amplifier _amplifier;
    private readonly DvdPlayer _dvdPlayer;
    private readonly Projector _projector;
    private readonly LightingSystem _lightingSystem;

    public HomeTheaterFacade(Amplifier amplifier, DvdPlayer dvdPlayer, Projector projector, LightingSystem lightingSystem)
    {
        _amplifier = amplifier;
        _dvdPlayer = dvdPlayer;
        _projector = projector;
        _lightingSystem = lightingSystem;
    }

    public void StartMovieExperience(string movie)
    {
        Console.WriteLine("Starting your movie experience...");

        _lightingSystem.DimLights();
        _amplifier.On();
        _amplifier.SetVolume(8);
        _projector.On();
        _projector.SetWideScreenMode();
        _dvdPlayer.On();
        _dvdPlayer.Play(movie);

        Console.WriteLine("Enjoy the movie!");
    }

    public void EndMovieExperience()
    {
        Console.WriteLine("Ending your movie experience...");

        _dvdPlayer.Stop();
        _dvdPlayer.Off();
        _projector.Off();
        _amplifier.Off();
        _lightingSystem.TurnOn();

        Console.WriteLine("Movie experience ended. Thank you!");
    }
}
