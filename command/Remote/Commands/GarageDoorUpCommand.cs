using Remote.Receivers;

namespace Remote.Commands;

public class GarageDoorUpCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorUpCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute() => _garageDoor.Up();
}
