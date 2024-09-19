namespace Remote.Receivers;

public class GarageDoor
{
    private readonly string _location;

    public GarageDoor(string location)
    {
        _location = location;
    }

    public void Up() => Console.WriteLine($"{_location} garage door is open");

    public void Down() => Console.WriteLine($"{_location} garage door is closed");

    public void Stop() => Console.WriteLine($"{_location} garage door is stopped");

    public void LightOn() => Console.WriteLine($"{_location} garage light is on");

    public void LightOff() => Console.WriteLine($"{_location} garage light is off");
}
