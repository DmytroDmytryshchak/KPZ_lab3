namespace lab03.Compon;

public abstract class LightNode
{
    public string Render()
    {
        OnCreated();
        BeforeRender();
        OnInserted();
        OnRemoved();
        OnTextRendered();

        string result = OuterHTML();

        AfterRender();
        return result;
    }
    
    public void Inserted()
    {
        OnInserted();
    }
    
    public void Removed()
    {
        OnRemoved();
    }
    
    protected virtual void OnCreated() { }
    protected virtual void BeforeRender() { }
    protected virtual void AfterRender() { }
    protected virtual void OnInserted() { }
    protected virtual void OnRemoved() { }
    protected virtual void OnTextRendered() { }
    
    public abstract string OuterHTML();
}