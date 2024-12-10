namespace House;

public class Roof
{
    public string Name { get; set; }

    public Roof(string material)
    {
        Name = $"Roof made out of {material}";
    }

    public override string ToString()
    {
        return Name;
    }
}
