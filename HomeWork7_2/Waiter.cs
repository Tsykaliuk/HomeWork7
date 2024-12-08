namespace Builder;

public class Waiter
{
    private PizzaBuilder? pizzaBuilder;

    public void SetPizzaBuilder(PizzaBuilder pb) => pizzaBuilder = pb;
    public Pizza GetPizza() => pizzaBuilder?.GetPizza() ?? throw new InvalidOperationException("PizzaBuilder not set");

    public void ConstructPizza()
    {
        if (pizzaBuilder == null)
        {
            throw new InvalidOperationException("PizzaBuilder not set");
        }

        pizzaBuilder.CreateNewPizza();
        pizzaBuilder.BuildDough();
        pizzaBuilder.BuildSauce();
        pizzaBuilder.BuildTopping();
    }
}
