namespace Mediator;

public class ConcreteMediator : Mediator
{
    public ConcreteColleague1? Colleague1 { private get; set; }
    public ConcreteColleague2? Colleague2 { private get; set; }
    public ConcreteColleague3? Colleague3 { private get; set; }

    public override void Send(string message, Colleague colleague)
    {
        if (colleague == Colleague1)
        {
            Colleague2?.Notify(message);
        }
        else if (colleague == Colleague2)
        {
            Colleague1?.Notify(message);
        }
        else if (colleague == Colleague3)
        {
            Colleague1?.Notify(message);
        }
    }
}
