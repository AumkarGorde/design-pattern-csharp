using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Vehicle
    {
        protected IFuelType _type;
        public Vehicle(IFuelType type)
        {
            _type = type;
        }

        public void Drive()
        {
            Console.WriteLine($"The vehicle is driving");
        }
    }
}
