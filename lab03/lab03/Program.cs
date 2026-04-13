using System;
using lab03.Adapter;
using lab03.Decorator;

public class Program
{
    public static void Main()
    {
        Adapter();
        Decorator();
    }
    
    static void Adapter()
    {
        Console.WriteLine("\tTask 1 | Adapter");
        
        // підзавдання 1(вивід у консоль різними кольорами)
        var consoleLogger = new Logger();
        consoleLogger.Log("Log message");
        consoleLogger.Warn("Warning message");
        consoleLogger.Error("Error message\n\n");

        
        // підзавдання 3(вивід у файл)
        var logger = new FileLogger("log.txt");
        logger.Log("Log message");
        logger.Warn("Warning message");
        logger.Error("Error message");
    }

    static void Decorator()
    {
        Console.WriteLine("\tTask 2 | Decorator");
        
        // створюємо Warrior та надаємо йому інвентар, а також дивимось нові характеристики героя
        Hero heroW = new Warrior();
        Console.WriteLine(heroW.GetDescription());
        Console.WriteLine("Hero's power: " + heroW.GetPower());
        heroW = new Armor(heroW);
        Console.WriteLine(heroW.GetDescription());
        Console.WriteLine("Hero's power: " + heroW.GetPower());
        heroW = new Weapon(heroW);
        Console.WriteLine(heroW.GetDescription());
        Console.WriteLine("Hero's power: " + heroW.GetPower());
        heroW = new Artifact(heroW);
        Console.WriteLine(heroW.GetDescription());
        Console.WriteLine("Hero's power: " + heroW.GetPower() + "\n");

        // створюємо Mage та надаємо йому інвентар, а також дивимось нові характеристики героя
        Hero heroM = new Mage();
        Console.WriteLine(heroM.GetDescription());
        Console.WriteLine("Hero's power: " + heroM.GetPower());
        heroM = new Armor(heroM);
        Console.WriteLine(heroM.GetDescription());
        Console.WriteLine("Hero's power: " + heroM.GetPower());
        heroM = new Weapon(heroM);
        Console.WriteLine(heroM.GetDescription());
        Console.WriteLine("Hero's power: " + heroM.GetPower() + "\n");

        // створюємо Mage та надаємо йому інвентар, а також дивимось нові характеристики героя
        Hero heroP = new Palladin();
        Console.WriteLine(heroP.GetDescription());
        Console.WriteLine("Hero's power: " + heroP.GetPower());
        heroP = new Armor(heroP);
        Console.WriteLine(heroP.GetDescription());
        Console.WriteLine("Hero's power: " + heroP.GetPower() + "\n");
    }
}