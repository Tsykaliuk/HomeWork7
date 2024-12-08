namespace FactoryMethod;

public class ViberMessage : Message
{
    public override void Send() => Console.WriteLine("Sending Viber Message...");
}
