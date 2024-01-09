using PizzaStoreSimpleFactory.Pizzas;
using PizzaStoreSimpleFactory.SimpleFactories;

namespace PizzaStoreSimpleFactory;

public class PizzaStore
{
    private readonly SimplePizzaFactory factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        this.factory = factory;
    }

    public Pizza OrderPizza(string type)
    {
        Pizza pizza;

        pizza = factory.CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

}
