using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Car : Vehicle
    {
        public Car(IFuelType type) : base(type)
        {
        }

        public void FuelUsed()
        {
            _type.Fuel();
        }
    }
}
