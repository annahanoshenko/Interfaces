using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    internal class Printer : ICanPrint, ICanScan
    {
        void ICanPrint.Start() // Explicit implementation of ICanPrint.Start
        {
            Console.WriteLine("Starting print job...");
        }
        
        void ICanScan.Start()
        {
            Console.WriteLine("Starting scan job...");
        }
    }
}
