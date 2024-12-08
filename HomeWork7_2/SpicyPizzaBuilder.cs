namespace Builder;

public class SpicyPizzaBuilder : PizzaBuilder
{
    public override void BuildDough() => pizza?.SetDough("panbaked");
    public override void BuildSauce() => pizza?.SetSauce("hot");
    public override void BuildTopping() => pizza?.SetTopping("pepperoni+salami");
}
