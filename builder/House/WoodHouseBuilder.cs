namespace House;

public class WoodHouseBuilder : HouseBuilder
{
    private readonly int _numWalls = 6;
    private readonly int _numWindows = 10;
    private readonly string _windowMaterial = "Tempered glass";
    private readonly string _wallMaterial = "Wood, 4x6";
    private readonly string _interiorWallMaterial = "Wood, 2x4";
    private readonly string _roofMaterial = "Metal";

    public WoodHouseBuilder()
    {
        BuilderName = "Wood House Builder";
        SetHouseType(HouseType.Wood);
    }

    public override HouseBuilder AddWalls()
    {
        for (var i = 0; i < 4; i++)
        {
            Console.WriteLine($"Nailing wood for wall made out of {_wallMaterial}");
            House.AddWall(new Wall(_wallMaterial));
        }

        for (var i = 0; i < _numWalls - 4; i++)
        {
            Console.WriteLine($"Nailing wood for interior wall made out of {_interiorWallMaterial}");
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
