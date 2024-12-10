namespace Pizza;

public class MeatLoversPizzaBuilder : PizzaBuilder
{
    public MeatLoversPizzaBuilder()
    {
        Name = "Meat Lovers Pizza";
    }

    public override PizzaBuilder AddCheese()
    {
        Toppings.Add("mozzarella");
        return this;
    }

    public override PizzaBuilder AddSauce()
    {
        Toppings.Add("NY style sauce");
        return this;
    }

    public override PizzaBuilder AddTomatoes()
    {
        Toppings.Add("sliced tomatoes");
        return this;
    }

    public override PizzaBuilder AddGarlic()
    {
        Toppings.Add("garlic");
        return this;
    }

    public override PizzaBuilder AddOlives()
    {
        return this;
    }

    public override PizzaBuilder AddSpinach()
    {
        return this;
    }

    public override PizzaBuilder AddPepperoni()
    {
        Toppings.Add("pepperoni");
        return this;
    }

    public override PizzaBuilder AddSausage()
    {
        Toppings.Add("sausage");
        return this;
    }
}
