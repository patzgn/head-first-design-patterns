using System.Text;

namespace Vacation;

public class Vacation
{
    public string Name { get; set; } = null!;
    public List<Accommodation> Accommodations { get; set; } = [];
    public List<string> Events { get; set; } = [];

    public override string ToString()
    {
        var display = new StringBuilder();
        display.AppendLine($"---- {Name} ----");

        foreach (var accommodation in Accommodations)
        {
            display.Append(accommodation);
        }

        foreach (var eventName in Events)
        {
            display.AppendLine(eventName);
        }

        return display.ToString();
    }
}
