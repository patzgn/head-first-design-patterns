namespace Vacation;

public abstract class VacationBuilder
{
    protected Vacation Vacation = new Vacation();
    
    public abstract VacationBuilder AddAccommodation();

    public abstract VacationBuilder AddAccommodation(string name);

    public abstract VacationBuilder AddAccommodation(string name, int year, int month, int day, int nights,
        int location);

    public abstract VacationBuilder AddEvent(string eventName);

    public Vacation Build() => Vacation;
}
