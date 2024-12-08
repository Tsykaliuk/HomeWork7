namespace Facade;

public class Amplifier
{
    public void On() => Console.WriteLine("Amplifier is on.");
    public void SetVolume(int volumeLevel) => Console.WriteLine($"Amplifier volume set to {volumeLevel}.");
    public void Off() => Console.WriteLine("Amplifier is off.");
}
