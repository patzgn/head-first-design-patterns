namespace House;

public class StoneHouseBuilder : HouseBuilder
{
    private readonly int _numWalls = 5;
    private readonly int _numWindows = 20;
    private readonly string _windowMaterial = "Antique glass";
    private readonly string _wallMaterial = "Stone, 2 feet thick";
    private readonly string _interiorWallMaterial = "Stone, 1 foot thick";
    private readonly string _roofMaterial = "Tile";

    public StoneHouseBuilder()
    {
        BuilderName = "Stone House Builder";
        SetHouseType(HouseType.Stone);
    }

    public override HouseBuilder AddWalls()
    {
        for (var i = 0; i < 4; i++)
        {
            Console.WriteLine($"Adding wall made out of {_wallMaterial}");
            House.AddWall(new Wall(_wallMaterial));
        }

        for (var i = 0; i < _numWalls - 4; i++)
        {
            Console.WriteLine($"Adding interior wall made out of {_interiorWallMaterial}");
            House.AddWall(new InteriorWall(_interiorWallMaterial));
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
