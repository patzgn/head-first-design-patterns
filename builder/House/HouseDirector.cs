namespace House;

public class HouseDirector
{
    public House BuildHouse(HouseBuilder builder) =>
        builder
            .AddWalls()
            .AddWindows()
            .AddRoof()
            .Build();
}
