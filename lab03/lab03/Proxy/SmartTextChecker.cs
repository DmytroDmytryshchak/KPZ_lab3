namespace lab03.Proxy;

public class SmartTextChecker : SmartTextReaderInt
{
    private SmartTextReaderInt reader;
    
    public SmartTextChecker(SmartTextReaderInt reader)
    {
        this.reader = reader;
    }

    public char[][] Read(string path)
    {
        Console.WriteLine($"Opening file: {path}");

        var result = reader.Read(path);
        if (result == null || result.Length == 0)
        {
            Console.WriteLine("No data returned (access denied or empty file)");
            return result;
        }
        
        int lines = result.Length;
        int chars = 0;

        foreach (var line in result)
        {
            chars += line.Length;
        }

        Console.WriteLine("File read successfully");
        Console.WriteLine($"Lines: {lines}, Characters: {chars}");
        Console.WriteLine("Closing file");

        return result;
    }
}