using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Electricity : IFuelType
    {
        public void Fuel()
        {
            Console.WriteLine("Electricity is used as fuel");
        }
    }
}
