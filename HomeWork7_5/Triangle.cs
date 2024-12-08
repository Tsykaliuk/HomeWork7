namespace PrototypeFigure;

public class Triangle : IFigure
{
    private int sideA, sideB, sideC;

    public Triangle(int sideA, int sideB, int sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public IFigure Clone()
    {
        return new Triangle(this.sideA, this.sideB, this.sideC);
    }

    public void GetInfo()
    {
        Console.WriteLine("Трикутник зі сторонами {0} {1} {2}", sideA, sideB, sideC);
    }
}
