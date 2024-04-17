
using LoggerService;

namespace LoggerTest;

public class LoggerInitTest
{
    [Fact]
    public void LoggerInitStatusOK()
    {
        string p = Environment.CurrentDirectory;
        var service = new Logger();
        string path = service.GetFilePath();
        Assert.Equal(path, p);
    }
}