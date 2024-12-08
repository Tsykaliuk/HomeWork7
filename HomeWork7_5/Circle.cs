namespace PrototypeFigure;

public class Circle : IFigure
{
    private int radius;

    public Circle(int r)
    {
        radius = r;
    }

    public IFigure Clone()
    {
        return new Circle(this.radius);
    }

    public void GetInfo()
    {
        Console.WriteLine("Круг радіусом {0}", radius);
    }
}
