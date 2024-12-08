namespace Builder;

public abstract class PizzaBuilder
{
    protected Pizza? pizza;

    public Pizza GetPizza() => pizza ?? throw new InvalidOperationException("Pizza not created");
    public void CreateNewPizza() => pizza = new Pizza();

    public abstract void BuildDough();
    public abstract void BuildSauce();
    public abstract void BuildTopping();
}
