namespace Decorator;

// "ConcreteDecoratorB"
public class GarlandDecorator : TreeDecorator
{
    public override void Display()
    {
        base.Display();
        AddGarland();
    }

    private void AddGarland()
    {
        Console.WriteLine("Added glowing garlands!");
    }
}
