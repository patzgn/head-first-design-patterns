using PizzaStoreFactoryMethod.Products.Pizzas;

namespace PizzaStoreFactoryMethod.FactoryMethods;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        switch (item)
        {
            case "cheese":
                return new NYStyleCheesePizza();
            case "veggie":
                return new NYStyleVeggiePizza();
            case "clam":
                return new NYStyleClamPizza();
            case "pepperoni":
                return new NYStylePepperoniPizza();
            default:
                return null;
        }
    }
}
