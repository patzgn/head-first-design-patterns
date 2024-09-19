namespace Remote.Receivers;

public class CeilingFan
{
    private readonly string _location;
    private int _level;

    public const int HIGH = 3;
    public const int MEDIUM = 2;
    public const int LOW = 1;


    public CeilingFan(string location)
    {
        _location = location;
    }

    public void High()
    {
        _level = HIGH;
        Console.WriteLine($"{_location} ceiling fan is on high");
    }

    public void Medium()
    {
        _level = MEDIUM;
        Console.WriteLine($"{_location} ceiling fan is on medium");
    }

    public void Low()
    {
        _level = LOW;
        Console.WriteLine($"{_location} ceiling fan is on low");
    }

    public void Off()
    {
        _level = 0;
        Console.WriteLine($"{_location} ceiling fan is off");
    }

    public int GetSpeed() => _level;
}
