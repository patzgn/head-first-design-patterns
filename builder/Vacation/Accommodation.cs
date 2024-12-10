using System.Text;

namespace Vacation;

public abstract class Accommodation
{
    public Reservation? Reservation { get; set; }

    protected string Name { get; set; } = null!;

    protected abstract string Location { get; }

    public override string ToString()
    {
        var display = new StringBuilder();
        display.AppendLine($"You're staying at {Name}");

        if (Reservation is not null)
        {
            display.Append(
                $"You have a reservation for arrival date: {Reservation.ArrivalDate}, staying for {Reservation.Nights} nights");
        }

        if (!string.IsNullOrEmpty(Location))
        {
            display.Append($" in {Location}");
        }

        display.AppendLine();
        return display.ToString();
    }
}
