namespace AbstractFactory;

public class FordFactory : ICarFactory
{
    public Car CreateCar() => new Ford();
    public Engine CreateEngine() => new FordEngine();
}
