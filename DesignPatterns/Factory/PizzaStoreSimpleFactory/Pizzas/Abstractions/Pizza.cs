using System.Text;

namespace PizzaStoreSimpleFactory.Pizzas;

public abstract class Pizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public ICollection<string> Toppings { get; set; } = new List<string>();

    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
    }

    public virtual void Bake()
    {
        Console.WriteLine($"Baking {Name}");
    }

    public virtual void Cut()
    {
        Console.WriteLine($"Cutting {Name}");
    }

    public virtual void Box()
    {
        Console.WriteLine($"Boxing {Name}");
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
