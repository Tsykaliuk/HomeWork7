namespace FactoryMethod;

public class ViberFactory : MessageFactory
{
    public override Message CreateMessage()
    {
        return new ViberMessage();
    }
}
