using PizzaStoreSimpleFactory.Pizzas;
using PizzaStoreSimpleFactory.SimpleFactories;
using static System.Formats.Asn1.AsnWriter;

namespace PizzaStoreSimpleFactory;

internal class Program
{
    static void Main(string[] args)
    {
        SimplePizzaFactory factory = new SimplePizzaFactory();
        PizzaStore store = new PizzaStore(factory);

        Pizza pizza = store.OrderPizza("cheese");
        Console.WriteLine($"We ordered a {pizza.Name} \n");
        Console.WriteLine(pizza);

        pizza = store.OrderPizza("veggie");
        Console.WriteLine($"We ordered a {pizza.Name} \n");
        Console.WriteLine(pizza);
    }
}
