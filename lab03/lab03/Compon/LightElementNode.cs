using System.Text;

namespace lab03.Compon;

public class LightElementNode : LightNode
{
    public string Tag;
    public bool IsBlock;
    public bool IsSelfClosing;
    public List<LightNode> Children = new();

    public LightElementNode(string tag, bool isBlock, bool isSelfClosing)
    {
        Tag = tag;
        IsBlock = isBlock;
        IsSelfClosing = isSelfClosing;
    }

    public void Add(LightNode node)
    {
        Children.Add(node);
    }

    public string InnerHTML()
    {
        StringBuilder sb = new();
        foreach (var child in Children)
        {
            sb.Append(child.OuterHTML());
        }

        return sb.ToString();
    }

    public override string OuterHTML()
    {
        if (IsSelfClosing)
        {
            return $"<{Tag}/>";
        }

        return $"<{Tag}>{InnerHTML()}</{Tag}>";
    }
}