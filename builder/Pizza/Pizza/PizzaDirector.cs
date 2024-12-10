namespace Pizza;

public class PizzaDirector
{
    public Pizza MakePizza(PizzaBuilder builder)
    {
        var pizza = builder
            .AddCheese()
            .AddSauce()
            .AddTomatoes()
            .AddGarlic()
            .AddOlives()
            .AddSpinach()
            .AddPepperoni()
            .AddSausage()
            .Build();

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
