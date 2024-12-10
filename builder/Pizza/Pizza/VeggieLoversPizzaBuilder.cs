namespace Pizza;

public class VeggieLoversPizzaBuilder : PizzaBuilder
{
    public VeggieLoversPizzaBuilder()
    {
        Name = "Veggie Lovers Pizza";
    }

    public override PizzaBuilder AddCheese()
    {
        Toppings.Add("parmesan");
        return this;
    }

    public override PizzaBuilder AddSauce()
    {
        Toppings.Add("sauce");
        return this;
    }

    public override PizzaBuilder AddTomatoes()
    {
        Toppings.Add("chopped tomatoes");
        return this;
    }

    public override PizzaBuilder AddGarlic()
    {
        Toppings.Add("garlic");
        return this;
    }

    public override PizzaBuilder AddOlives()
    {
        Toppings.Add("green olives");
        return this;
    }

    public override PizzaBuilder AddSpinach()
    {
        Toppings.Add("spinach");
        return this;
    }

    public override PizzaBuilder AddPepperoni()
    {
        return this;
    }

    public override PizzaBuilder AddSausage()
    {
        return this;
    }
}
