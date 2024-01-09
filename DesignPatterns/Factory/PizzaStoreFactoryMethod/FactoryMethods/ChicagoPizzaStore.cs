using PizzaStoreFactoryMethod.Products.Pizzas;

namespace PizzaStoreFactoryMethod.FactoryMethods;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        switch (item)
        {
            case "cheese":
                return new ChicagoStyleCheesePizza();
            case "veggie":
                return new ChicagoStyleVeggiePizza();
            case "clam":
                return new ChicagoStyleClamPizza();
            case "pepperoni":
                return new ChicagoStylePepperoniPizza();
            default:
                return null;
        }
    }
}
