namespace lab03.Bridge;

public class Triangle : Shape
{
    public Triangle(Renderer renderer) : base(renderer) {}

    public override void Draw()
    {
        renderer.Render("Triangle");
    }
}