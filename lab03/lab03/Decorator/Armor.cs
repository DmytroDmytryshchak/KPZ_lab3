namespace lab03.Decorator;

public class Armor : HeroDecorator
{
    public Armor(Hero hero) : base(hero) {}

    public override string GetDescription() => hero.GetDescription() + " + Armor";
    public override int GetPower() => hero.GetPower() + 5;
}