namespace Pizza;

public abstract class PizzaBuilder
{
    protected string Name = "Pizza";
    protected List<string> Toppings = [];

    public abstract PizzaBuilder AddCheese();
    public abstract PizzaBuilder AddSauce();
    public abstract PizzaBuilder AddTomatoes();
    public abstract PizzaBuilder AddGarlic();
    public abstract PizzaBuilder AddOlives();
    public abstract PizzaBuilder AddSpinach();
    public abstract PizzaBuilder AddPepperoni();
    public abstract PizzaBuilder AddSausage();

    public Pizza Build() => new Pizza(Name, Toppings);
}
