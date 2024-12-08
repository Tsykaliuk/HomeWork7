namespace Decorator;

// "Decorator"
public abstract class TreeDecorator : Tree
{
    protected Tree? tree;

    public void SetTree(Tree tree)
    {
        this.tree = tree;
    }

    public override void Display()
    {
        tree?.Display();
    }
}
