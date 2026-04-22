namespace lab03.Compon.State;

using lab03.Compon;

public class VisibleState : IElementState
{
    public string Render(LightElementNode node)
    {
        return node.DefaultRender();
    }
}