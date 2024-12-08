using System.Text;

using PrototypeFigure;

Console.OutputEncoding = Encoding.UTF8;

IFigure figure = new Rectangle(10, 20);
IFigure clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

figure = new Circle(15);
clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

figure = new Triangle(3, 4, 5);
clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

Console.ReadKey();