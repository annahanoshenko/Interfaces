using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    internal interface IVehicle
    {
        void Start();
        void Stop();
        void DisplayStatus();

        void Refuel(int liters);

    }
    
}
