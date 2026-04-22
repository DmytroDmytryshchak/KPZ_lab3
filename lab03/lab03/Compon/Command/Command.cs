namespace lab03.Compon.Command;

public interface ICommand
{
    void Execute();
    void Undo();
}