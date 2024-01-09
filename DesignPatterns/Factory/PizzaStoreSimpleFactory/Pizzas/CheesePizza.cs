namespace PizzaStoreSimpleFactory.Pizzas;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Name = "Cheese Pizza";
        Dough = "Regular crust";
        Sauce = "Marinara pizza sauce";

        Toppings.Add("Fresh Mozzarella");
        Toppings.Add("Parmesan");
    }
}
