using Builder;

Waiter waiter = new();
PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();

waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
waiter.ConstructPizza();
Pizza pizza = waiter.GetPizza();
pizza.Info();

Console.WriteLine("------------");

waiter.SetPizzaBuilder(margaritaPizzaBuilder);
waiter.ConstructPizza();
pizza = waiter.GetPizza();
pizza.Info();

Console.ReadKey();
