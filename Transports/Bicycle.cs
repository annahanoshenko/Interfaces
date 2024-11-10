using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    internal class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bicycle is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Bicycke is stopping");
        }
        public void DisplayStatus()
        {
            Console.WriteLine("Ready to ride.");
        }

        public void Refuel(int liters)
        {
            Console.WriteLine("Don`t need a fuel");
        }
        
    }
}
