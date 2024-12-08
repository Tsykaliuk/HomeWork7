namespace AbstractFactory;

public class ToyotaFactory : ICarFactory
{
    public Car CreateCar() => new Toyota();
    public Engine CreateEngine() => new ToyotaEngine();
}
