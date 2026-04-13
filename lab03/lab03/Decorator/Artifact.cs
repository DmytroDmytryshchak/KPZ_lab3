namespace lab03.Decorator;

public class Artifact : HeroDecorator
{
    public Artifact(Hero hero) : base(hero) {}

    public override string GetDescription() => hero.GetDescription() + " + Artifact";
    public override int GetPower() => hero.GetPower() + 10;
}