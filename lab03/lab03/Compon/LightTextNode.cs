namespace lab03.Compon;

public class LightTextNode :LightNode
{
    private string text;

    public LightTextNode(string text)
    {
        this.text = text;
    }

    public override string OuterHTML()
    {
        OnTextRendered();
        return text;
    }
}