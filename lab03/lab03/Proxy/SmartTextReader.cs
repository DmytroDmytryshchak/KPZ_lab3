namespace lab03.Proxy;

public class SmartTextReader : SmartTextReaderInt
{
    public char[][] Read(string path)
    {
        var lines = File.ReadAllLines(path);
        return lines.Select(ln => ln.ToCharArray()).ToArray();
    }
}