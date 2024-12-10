namespace House;

public class InteriorWall : Wall
{
    public InteriorWall(string material) : base(material)
    {
        Name = $"Interior wall made out of {material}";
    }
}
