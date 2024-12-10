namespace House;

public abstract class HouseBuilder
{
    public string BuilderName { get; set; } = "Builder Name";

    protected House House = new House();

    protected void SetHouseType(HouseType houseType) => House.SetHouseType(houseType);

    public abstract HouseBuilder AddWalls();
    public abstract HouseBuilder AddRoof();
    public abstract HouseBuilder AddWindows();

    public House Build()
    {
        Console.WriteLine("Build the house");
        return House;
    }
}
