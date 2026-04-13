using System;
using System.Reflection;
using lab03.Adapter;
using lab03.Decorator;
using lab03.Bridge;
using lab03.Proxy;

public class Program
{
    public static void Main()
    {
        Adapter();
        Decorator();
        Bridge();
        Proxy();
    }
    
    static void Adapter()
    {
        Console.WriteLine("\tTask 1 | Adapter");
        
        // підзавдання 1(вивід у консоль різними кольорами)
        var consoleLogger = new Logger();
        consoleLogger.Log("Log message");
        consoleLogger.Warn("Warning message");
        consoleLogger.Error("Error message\n");

        
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

    static void Bridge()
    {
        Console.WriteLine("\tTask 3 | Bridge");
        
        // Створюємо круг та робимо рендеринг векторової графіки
        Shape circle = new Circle(new VectorRender());
        circle.Draw();
        
        // Створюємо квадрат та робимо рендеринг растрової графіки
        Shape square = new Square(new RastRender());
        square.Draw();
        
        // Створюємо 2 трикутники та робимо 2 рендеренги: 1 - векторова графіка, 2 - растрова графіка 
        Shape triangle1 = new Triangle(new VectorRender());
        Shape triangle2 = new Triangle(new RastRender());
        triangle1.Draw();
        triangle2.Draw();
    }

    static void Proxy()
    {
        Console.WriteLine("\n\tTask 4 | Proxy");
        
        // Створюємо рідер файлів та створюємо "секретні файли" з лімітованим доступом
        SmartTextReaderInt reader = new SmartTextChecker(new SmartTextReaderLocker(new SmartTextReader(), "secret.*"));

        reader.Read("log.txt");
        reader.Read("secret.txt");
    }
}