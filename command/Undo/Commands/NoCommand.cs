namespace Undo.Commands;

public class NoCommand : ICommand
{
    public void Execute() { }

    public void Undo() { }
}
