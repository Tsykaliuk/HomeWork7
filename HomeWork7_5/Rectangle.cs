namespace PrototypeFigure;

public class Rectangle : IFigure
{
    private int width;
    private int height;

    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }

    public IFigure Clone()
    {
        return new Rectangle(this.width, this.height);
    }

    public void GetInfo()
    {
        Console.WriteLine("Прямокутник довжиною {0} і шириною {1}", height, width);
    }
}
