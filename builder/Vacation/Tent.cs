namespace Vacation;

public class Tent : Accommodation
{
    public int SiteNumber { get; set; }

    public Tent()
    {
        Name = "Tent";
    }

    public Tent(string name)
    {
        Name = name;
    }

    protected override string Location => SiteNumber == 0 ? "" : $"Site number {SiteNumber}";
}
