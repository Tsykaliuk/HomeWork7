namespace Builder;

public class MargaritaPizzaBuilder : PizzaBuilder
{
    public override void BuildDough() => pizza?.SetDough("panbaked");
    public override void BuildSauce() => pizza?.SetSauce("tomato sauce");
    public override void BuildTopping() => pizza?.SetTopping("mozzarella+basil+tomato");
}
