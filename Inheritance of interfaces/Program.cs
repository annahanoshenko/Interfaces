using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.Save();
            document.Open();
            document.Close();
            document.Print();

        }
    }
}
