namespace Decorator;

// "ConcreteDecoratorC"
public class StarDecorator : TreeDecorator
{
    public override void Display()
    {
        base.Display();
        AddStar();
    }

    private void AddStar()
    {
        Console.WriteLine("A shining star is placed on top of the tree!");
    }
}
