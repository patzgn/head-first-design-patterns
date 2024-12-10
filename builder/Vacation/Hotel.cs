namespace Vacation;

public class Hotel : Accommodation
{
    public int RoomNumber { get; set; }

    public Hotel()
    {
        Name = "Hotel";
    }

    public Hotel(string name)
    {
        Name = name;
    }

    protected override string Location => RoomNumber == 0 ? "" : $"Room number {RoomNumber}";
}
