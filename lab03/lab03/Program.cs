using System;
using lab03.Adapter;

public class Program
{
    public static void Main()
    {
        Adapter();
    }
    
    static void Adapter()
    {
        // підзавдання 1(вивід у консоль різними кольорами)
        var consoleLogger = new Logger();
        consoleLogger.Log("Log message");
        consoleLogger.Warn("Warning message");
        consoleLogger.Error("Error message");

        
        // підзавдання 3(вивід у файл)
        var logger = new FileLogger("log.txt");
        logger.Log("Log message");
        logger.Warn("Warning message");
        logger.Error("Error message");
    }
}