namespace Undo.Receivers;

public class CeilingFan
{
    public const int HIGH = 3;
    public const int MEDIUM = 2;
    public const int LOW = 1;
    public const int OFF = 0;

    public int Speed { get; private set; }

    private readonly string _location;

    public CeilingFan(string location)
    {
        _location = location;
        Speed = OFF;
    }

    public void High()
    {
        Speed = HIGH;
        Console.WriteLine($"{_location} ceiling fan is on high");
    }

    public void Medium()
    {
        Speed = MEDIUM;
        Console.WriteLine($"{_location} ceiling fan is on medium");
    }

    public void Low()
    {
        Speed = LOW;
        Console.WriteLine($"{_location} ceiling fan is on low");
    }

    public void Off()
    {
        Speed = OFF;
        Console.WriteLine($"{_location} ceiling fan is off");
    }
}
