namespace House;

public class Window
{
    public string Name { get; set; }

    public Window(string material)
    {
        Name = $"Window made out of {material}";
    }

    public override string ToString()
    {
        return Name;
    }
}
