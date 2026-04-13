namespace lab03.Proxy;

using System.Text.RegularExpressions;

public class SmartTextReaderLocker : SmartTextReaderInt
{
    private SmartTextReaderInt reader;
    private Regex secretFiles;
    
    public SmartTextReaderLocker(SmartTextReaderInt reader, string pattern)
    {
        this.reader = reader;
        secretFiles = new Regex(pattern);
    }
    
    public char[][] Read(string path)
    {
        if (secretFiles.IsMatch(path))
        {
            Console.WriteLine("Access denied!");
            return new char[0][];
        }

        return reader.Read(path);
    }
}