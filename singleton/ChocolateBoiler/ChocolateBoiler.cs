namespace ChocolateBoiler;

public class ChocolateBoiler
{
    private bool _empty;
    private bool _boiled;

    private static ChocolateBoiler? _uniqueInstance;

    private ChocolateBoiler()
    {
        _empty = true;
        _boiled = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        if (_uniqueInstance is null)
        {
            _uniqueInstance = new ChocolateBoiler();
        }

        return _uniqueInstance;
    }

    public void Fill()
    {
        if (_empty)
        {
            _empty = false;
            _boiled = false;
            // Fill the boiler with a milk/chocolate mixture
        }
    }

    public void Drain()
    {
        if (!_empty && _boiled)
        {
            // Drain the boiled milk and chocolate
            _empty = true;
        }
    }

    public void Boil()
    {
        if (!_empty && _boiled)
        {
            // Bring the contents to a boil
            _boiled = true;
        }
    }
}
