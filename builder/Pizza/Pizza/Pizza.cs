using System.Text;

namespace Pizza;

public class Pizza(string name, List<string> toppings)
{
    public void Prepare()
    {
        Console.WriteLine($"Prepare {name}");
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings:");
        foreach (var topping in toppings)
        {
            Console.WriteLine($"   {topping}");
        }
    }

    public void Bake() => Console.WriteLine("Bake for 25 minutes at 350");

    public void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");

    public void Box() => Console.WriteLine("Place pizza in official PizzaStore box");

    public override string ToString()
    {
        var display = new StringBuilder();
        display.AppendLine($"---- {name} ----");
        foreach (var topping in toppings)
        {
            display.AppendLine($"{topping}");
        }

        return display.ToString();
    }
}
