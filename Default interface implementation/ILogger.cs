using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_interface_implementation
{
    internal interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine($"Log entry: {message}");
        }

        void LogError(string error)
        {
            Console.WriteLine($"Error entry: {error}");
        }
    }

}
