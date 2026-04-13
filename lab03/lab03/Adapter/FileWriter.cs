namespace lab03.Adapter;

public class FileWriter
{
    public String path;
    
    public FileWriter(string path)
    {
        this.path = path;
    }

    public void Write(string text)
    {
        File.AppendAllText(path, text);
    }

    public void WriteLine(string text)
    {
        File.AppendAllText(path, text + "\n");
    }
}