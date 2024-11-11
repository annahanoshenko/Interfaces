using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_interfaces
{
    public class Document : IDocument
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving document...");
        }

        public void Open()
        {
            Console.WriteLine("Open document...");
        }
        public void Close()
        {
            Console.WriteLine("Close document...");
        }
    }
}

