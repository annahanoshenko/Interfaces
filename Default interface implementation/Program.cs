

namespace Default_interface_implementation
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Log("This is a standard log message.");
            logger.LogError("This is a standard error.");

            ILogger filelogger = new FileLogger();
            filelogger.Log("Logging to file...");
            filelogger.LogError("File error.");

        }
    }
}
