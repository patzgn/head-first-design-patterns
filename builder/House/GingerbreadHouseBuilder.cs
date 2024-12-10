namespace House;

public class GingerbreadHouseBuilder : HouseBuilder
{
    private readonly int _numWalls = 4;
    private readonly int _numWindows = 4;
    private readonly string _windowMaterial = "Sugar";
    private readonly string _wallMaterial = "Gingerbread and icing";
    private readonly string _roofMaterial = "Twizzlers";

    public GingerbreadHouseBuilder()
    {
        BuilderName = "Gingerbread House Builder";
        SetHouseType(HouseType.Gingerbread);
    }

    public override HouseBuilder AddWalls()
    {
        for (var i = 0; i < _numWalls; i++)
        {
            Console.WriteLine($"Adding wall made out of {_wallMaterial}");
            House.AddWall(new Wall(_wallMaterial));
        }

        return this;
    }

    public override HouseBuilder AddRoof()
    {
        House.AddRoof(new Roof(_roofMaterial));
        return this;
    }

    public override HouseBuilder AddWindows()
    {
        for (var i = 0; i < _numWindows; i++)
        {
            Console.WriteLine($"Adding window made out of {_windowMaterial}");
            House.AddWindow(new Window(_windowMaterial));
        }

        return this;
    }
}
