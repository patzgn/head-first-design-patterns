namespace PizzaStoreSimpleFactory.Pizzas;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "Pepperoni Pizza";
        Dough = "Crust";
        Sauce = "Marinara sauce";

        Toppings.Add("Sliced pepperoni");
        Toppings.Add("Sliced onion");
        Toppings.Add("Grated parmesan cheese");
    }
}
