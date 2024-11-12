using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_interface_implementation
{
    internal class FileLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine($"File log error: {error}");
        }
    }
}
