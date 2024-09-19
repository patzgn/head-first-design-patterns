namespace ChocolateBoiler;

public class ChocolateBoilerWithLock
{
    public string Name { get; set; }

    private bool _empty;
    private bool _boiled;

    private static ChocolateBoilerWithLock? _uniqueInstance;

    private static readonly object _sync = new();

    private ChocolateBoilerWithLock(string name)
    {
        Name = name;

        _empty = true;
        _boiled = false;
    }

    public static ChocolateBoilerWithLock GetInstance(string name)
    {
        if (_uniqueInstance is null)
        {
            lock (_sync)
            {
                if (_uniqueInstance is null)
                {
                    _uniqueInstance = new ChocolateBoilerWithLock(name);
                }
            }
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
