namespace lab03.Compon.Command;

public class AddNodeCommand : ICommand
{
    private LightElementNode parent;
    private LightNode child;

    public AddNodeCommand(LightElementNode parent, LightNode child)
    {
        this.parent = parent;
        this.child = child;
    }

    public void Execute() => parent.Add(child);

    public void Undo() => parent.Children.Remove(child);
}