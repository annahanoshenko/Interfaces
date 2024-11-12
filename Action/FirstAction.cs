using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    internal class FirstAction : IFirstInterface, ISecondInterface
    {
        public void Action() 
        {
            Console.WriteLine("Class Action...");
        }
    }
}
