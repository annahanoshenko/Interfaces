using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    internal class Bus : IVehicle
    {
        public int MaxPassengerCount { get; set; }
        public int FuelLevel {  get; set; } 

        public Bus(int maxPassengerCount)
        {
            MaxPassengerCount = maxPassengerCount;
        }

        public void Start()
        {
            Console.WriteLine("Bus is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Bus is stopping");
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"Bus has {MaxPassengerCount} passengers.");
        }

       public void Refuel(int liters)
        {
            FuelLevel += liters;
            Console.WriteLine($"bus refueled with {liters} liters. Current fuel level: {FuelLevel} liters.");
        }
    }
}
