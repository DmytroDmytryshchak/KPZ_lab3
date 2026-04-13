namespace lab03.Bridge;

public class Circle : Shape
{
    public Circle(Renderer renderer) : base(renderer) {}

    public override void Draw()
    {
        renderer.Render("Circle");
    }
}