namespace AbstractFactory;

public class MersedesFactory : ICarFactory
{
    public Car CreateCar() => new Mersedes();
    public Engine CreateEngine() => new MersedesEngine();
}
