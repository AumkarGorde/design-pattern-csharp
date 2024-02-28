using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Petrol : IFuelType
    {
        public void Fuel()
        {
            Console.WriteLine("Petrol is used as Fuel");
        }
    }
}
