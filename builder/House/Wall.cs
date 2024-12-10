namespace House;

public class Wall
{
    public string Name { get; set; }

    public Wall(string material)
    {
        Name = $"Wall made out of {material}";
    }

    public override string ToString()
    {
        return Name;
    }
}
