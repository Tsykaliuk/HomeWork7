namespace Decorator;
// "ConcreteDecoratorA"
public class OrnamentDecorator : TreeDecorator
{
    public override void Display()
    {
        base.Display();
        AddOrnaments();
    }

    private void AddOrnaments()
    {
        Console.WriteLine("Decorated with shiny ornaments!");
    }
}
