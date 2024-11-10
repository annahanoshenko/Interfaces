using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    internal class Car : IVehicle
    {
        public int PassengersCount {  get; set; }  
        public int FuelLevel {  get; set; }

        public Car(int passengersCount)
        {
            PassengersCount = passengersCount;
        }
        public void Start()
        {
            Console.WriteLine("Car is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
        public void DisplayStatus()
        {
            Console.WriteLine( $"Car has {PassengersCount} passengers.");
        }
        public void Refuel(int liters)
        {
            FuelLevel += liters;
            Console.WriteLine($"Car refueled with {liters} liters. Current fuel level: {FuelLevel} liters.");
        }
    }
}
