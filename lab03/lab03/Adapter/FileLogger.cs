namespace lab03.Adapter;

public class FileLogger
{
    private FileWriter writer;

    public FileLogger(string path)
    {
        writer = new FileWriter(path);
    }

    public void Log(string msg)
    {
        writer.WriteLine("[LOG] " + msg);
    }

    public void Warn(string msg)
    {
        writer.WriteLine("[WARN] " + msg);
    }

    public void Error(string msg)
    {
        writer.WriteLine("[ERROR] " + msg);
    }
}