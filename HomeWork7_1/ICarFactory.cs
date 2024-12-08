namespace AbstractFactory;

public interface ICarFactory
{
    Car CreateCar();
    Engine CreateEngine();
}
