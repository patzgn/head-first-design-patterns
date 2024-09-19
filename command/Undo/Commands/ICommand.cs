namespace Undo.Commands;

public interface ICommand
{
    void Execute();
    void Undo();
}
