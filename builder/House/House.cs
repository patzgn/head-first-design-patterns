using System.Text;

namespace House;

public class House
{
    private string _name = "House Name";

    private HouseType _houseType;

    private Roof _roof = default!;

    private List<Wall> _walls = [];

    private List<Window> _windows = [];

    public void SetHouseType(HouseType houseType)
    {
        _houseType = houseType;

        _name = _houseType switch
        {
            HouseType.Gingerbread => "My holiday gingerbread house",
            HouseType.Stone => "My stone house",
            HouseType.Wood => "My wood house",
            _ => _name
        };
    }

    public void AddRoof(Roof roof)
    {
        _roof = roof;
    }

    public void AddWall(Wall wall)
    {
        _walls.Add(wall);
    }

    public void AddWindow(Window window)
    {
        _windows.Add(window);
    }

    public override string ToString()
    {
        var display = new StringBuilder();
        display.AppendLine($"---- {_name} ----");
        foreach (var wall in _walls)
        {
            display.AppendLine($"--- {wall.Name} ---");
        }

        foreach (var window in _windows)
        {
            display.AppendLine($"--- {window.Name} ---");
        }

        display.AppendLine($"--- {_roof.Name} ---");

        return display.ToString();
    }
}
