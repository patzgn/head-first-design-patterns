using System.Text;

namespace PizzaStoreFactoryMethod.Products.Pizzas;

public abstract class Pizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public ICollection<string> Toppings { get; set; } = new List<string>();

    public virtual void Prepare()
    {
        Console.WriteLine($"Prepare {Name}");
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
        foreach (var topping in Toppings)
        {
            Console.WriteLine($"   {topping}");
        }
    }

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cut the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"---- {Name} ----");
        result.AppendLine(Dough);
        result.AppendLine(Sauce);
        foreach (var topping in Toppings)
        {
            result.AppendLine(topping);
        }

        return result.ToString();
    }
}
