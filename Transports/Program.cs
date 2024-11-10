using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>
            {
                new Car(4),
                new Bus(20),
                new Bicycle()
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.Start();
                vehicle.DisplayStatus();
                vehicle.Refuel(10);
                vehicle.DisplayStatus();
                vehicle.Stop();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
