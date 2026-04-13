namespace lab03.Decorator;

public abstract class HeroDecorator : Hero
{
    protected Hero hero;

    public HeroDecorator(Hero hero)
    {
        this.hero = hero;
    }
    
    public virtual string GetDescription() => hero.GetDescription();
    public virtual int GetPower() => hero.GetPower();
}