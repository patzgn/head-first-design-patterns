namespace Vacation;

public class CityVacationBuilder : VacationBuilder
{
    public CityVacationBuilder()
    {
        Vacation.Name = "City Vacation";
    }

    public override VacationBuilder AddAccommodation()
    {
        Vacation.Accommodations.Add(new Hotel());
        return this;
    }

    public override VacationBuilder AddAccommodation(string name)
    {
        Vacation.Accommodations.Add(new Hotel(name));
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

        var hotel = new Hotel(name)
        {
            Reservation = reservation,
            RoomNumber = location,
        };

        Vacation.Accommodations.Add(hotel);
        return this;
    }

    public override VacationBuilder AddEvent(string eventName)
    {
        Vacation.Events.Add($"See the {eventName} show");
        return this;
    }
}
