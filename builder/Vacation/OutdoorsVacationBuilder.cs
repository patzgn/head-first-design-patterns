namespace Vacation;

public class OutdoorsVacationBuilder : VacationBuilder
{
    public OutdoorsVacationBuilder()
    {
        Vacation.Name = "Outdoorsy Vacation";
    }

    public override VacationBuilder AddAccommodation()
    {
        Vacation.Accommodations.Add(new Tent());
        return this;
    }

    public override VacationBuilder AddAccommodation(string name)
    {
        Vacation.Accommodations.Add(new Tent(name));
        return this;
    }

    public override VacationBuilder AddAccommodation(string name, int year, int month, int day, int nights,
        int location)
    {
        var reservation = new Reservation
        {
            ArrivalDate = new DateTime(year, month, day),
            Nights = nights,
        };

        var tent = new Tent(name)
        {
            Reservation = reservation,
            SiteNumber = location,
        };

        Vacation.Accommodations.Add(tent);
        return this;
    }

    public override VacationBuilder AddEvent(string eventName)
    {
        Vacation.Events.Add($"Hike: {eventName}");
        return this;
    }
}
