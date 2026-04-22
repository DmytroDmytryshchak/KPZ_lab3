namespace lab03.Compon.Iterator;

public class DepthIterator : NodeIterator
{
    private Stack<LightNode> stack = new();

    public DepthIterator(LightNode root)
    {
        stack.Push(root);
    }

    public bool HasNext() => stack.Count > 0;

    public LightNode Next()
    {
        var node = stack.Pop();

        if (node is LightElementNode el)
        {
            for (int i = el.Children.Count - 1; i >= 0; i--)
                stack.Push(el.Children[i]);
        }

        return node;
    }
}