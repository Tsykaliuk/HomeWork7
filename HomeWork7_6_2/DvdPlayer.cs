namespace Facade;

public class DvdPlayer
{
    public void On() => Console.WriteLine("DVD Player is on.");
    public void Play(string movieName) => Console.WriteLine($"Playing movie: {movieName}.");
    public void Stop() => Console.WriteLine("DVD Player stopped.");
    public void Off() => Console.WriteLine("DVD Player is off.");
}
