using PizzaStoreFactoryMethod.FactoryMethods;
using PizzaStoreFactoryMethod.Products.Pizzas;

namespace PizzaStoreFactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine($"Ethan ordered a {pizza.Name} \n");

        pizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine($"Joel ordered a {pizza.Name} \n");

        pizza = nyStore.OrderPizza("clam");
        Console.WriteLine($"Ethan ordered a {pizza.Name} \n");

        pizza = chicagoStore.OrderPizza("clam");
        Console.WriteLine($"Joel ordered a {pizza.Name} \n");

        pizza = nyStore.OrderPizza("pepperoni");
        Console.WriteLine($"Ethan ordered a {pizza.Name} \n");

        pizza = chicagoStore.OrderPizza("pepperoni");
        Console.WriteLine($"Joel ordered a {pizza.Name} \n");

        pizza = nyStore.OrderPizza("veggie");
        Console.WriteLine($"Ethan ordered a {pizza.Name} \n");

        pizza = chicagoStore.OrderPizza("veggie");
        Console.WriteLine($"Joel ordered a {pizza.Name} \n");
    }
}
