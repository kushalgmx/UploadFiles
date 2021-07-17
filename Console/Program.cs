using Serilog;
using Serilog.Events;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();
            Log.Information("hello, world");
        }
    }
}
