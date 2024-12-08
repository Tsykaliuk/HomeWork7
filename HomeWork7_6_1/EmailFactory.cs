namespace FactoryMethod;

public class EmailFactory : MessageFactory
{
    public override Message CreateMessage()
    {
        return new EmailMessage();
    }
}
