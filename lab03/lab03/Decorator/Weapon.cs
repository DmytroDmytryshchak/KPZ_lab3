namespace lab03.Decorator;

public class Weapon : HeroDecorator
{
    public Weapon(Hero hero) : base(hero) {}
    
    public override string GetDescription() => hero.GetDescription() + " + Weapon";
    public override int GetPower() => hero.GetPower() + 10;
}