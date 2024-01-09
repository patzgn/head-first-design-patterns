using PizzaStoreAbstractFactory.Products.Ingredients;
using System.Text;

namespace PizzaStoreAbstractFactory.Products.Pizzas;

public abstract class Pizza
{
    public string Name { get; set; }

    public IDough? Dough { get; set; }
    public ISauce? Sauce { get; set; }
    public IVeggies[]? Veggies { get; set; }
    public ICheese? Cheese { get; set; }
    public IPepperoni? Pepperoni { get; set; }
    public IClams? Clam { get; set; }

    public abstract void Prepare();

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

        if (Dough is not null)
        {
            result.AppendLine(Dough.ToString());
        }
        if (Sauce is not null)
        {
            result.AppendLine(Sauce.ToString());
        }
        if (Cheese is not null)
        {
            result.AppendLine(Cheese.ToString());
        }
        if (Veggies is not null)
        {
            for (int i = 0; i < Veggies.Length; i++)
            {
                result.Append(Veggies[i].ToString());
                if (i < Veggies.Length - 1)
                {
                    result.Append(", ");
                }
            }
            result.Append('\n');
        }
        if (Clam is not null)
        {
            result.AppendLine(Clam.ToString());
        }
        if (Pepperoni is not null)
        {
            result.AppendLine(Pepperoni.ToString());
        }

        return result.ToString();
    }
}
