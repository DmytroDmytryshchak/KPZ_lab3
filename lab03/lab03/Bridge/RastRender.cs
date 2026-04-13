namespace lab03.Bridge;

public class RastRender : Renderer
{
    public void Render(string shape)
    {
        Console.WriteLine($"Drawing {shape} as pixels");
    }    
}