namespace lab03.Bridge;

public class Square : Shape
{
    public Square(Renderer renderer) : base(renderer) {}

    public override void Draw()
    {
        renderer.Render("Square");
    }
}