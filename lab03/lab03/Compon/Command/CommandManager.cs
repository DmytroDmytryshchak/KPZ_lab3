namespace lab03.Compon.Command;

public class CommandManager
{
    private Stack<ICommand> history = new();

    public void Execute(ICommand cmd)
    {
        cmd.Execute();
        history.Push(cmd);
    }

    public void Undo()
    {
        if (history.Count > 0)
            history.Pop().Undo();
    }
}