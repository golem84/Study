

namespace LoggerService;

public class Logger
{
    string logpath= System.Environment.CurrentDirectory;
    private FileInfo logfile;

    public Logger() 
    {
        
    }

    public string GetFilePath()
    {
        return logpath;
    }
}
