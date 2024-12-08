namespace FactoryMethod;

public class EmailMessage : Message
{
    public override void Send() => Console.WriteLine("Sending Email Message...");
}