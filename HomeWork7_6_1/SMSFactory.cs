namespace FactoryMethod;

public class SMSFactory : MessageFactory
{
    public override Message CreateMessage()
    {
        return new SMSMessage();
    }
}
