using System.Text;
using lab03.Compon.State;

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
        
        OnCreated();
    }

    public void Add(LightNode node)
    {
        Children.Add(node);
        node.Inserted();
    }
    
    public void Remove(LightNode node)
    {
        Children.Remove(node);
        node.Removed();
    }

    public string InnerHTML()
    {
        StringBuilder sb = new();
        foreach (var child in Children)
        {
            sb.Append(child.Render());
        }

        return sb.ToString();
    }

    public override string OuterHTML()
    {
        /*
        if (IsSelfClosing)
        {
            return $"<{Tag}/>";
        }

        return $"<{Tag}>{InnerHTML()}</{Tag}>";
        */
        return State.Render(this);
    }
    
    protected override void BeforeRender()
    {
        // Console.WriteLine($"Rendering <{Tag}>");
    }
    
    protected override void OnCreated()
    {
        //Console.WriteLine("Element created: " + Tag);
    }

    protected override void OnInserted()
    {
        //Console.WriteLine("Element inserted: " + Tag);
    }
    
    public IElementState State = new VisibleState();
    
    public string DefaultRender()
    {
        if (IsSelfClosing)
            return $"<{Tag}/>";

        return $"<{Tag}>{InnerHTML()}</{Tag}>";
    }
}