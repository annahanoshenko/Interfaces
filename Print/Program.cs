using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            ICanPrint printable = printer;
            printable.Start();
            

            ICanScan scanable = printer;
            scanable.Start();
        }
    }
}
