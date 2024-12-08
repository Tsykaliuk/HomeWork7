namespace FactoryMethod;

public class SMSMessage : Message
{
    public override void Send() => Console.WriteLine("Sending SMS Message...");
}
