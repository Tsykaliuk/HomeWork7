namespace Mediator;

public class ConcreteColleague3 : Colleague
{
    public ConcreteColleague3(Mediator mediator) : base(mediator) { }

    public void Send(string message)
    {
        Mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("Colleague3 gets message: " + message);
    }
}
