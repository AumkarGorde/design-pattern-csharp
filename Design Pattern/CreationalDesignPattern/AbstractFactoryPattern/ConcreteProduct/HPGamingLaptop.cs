using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class HPGamingLaptop : GamingLaptop
    {
        public override void LaptopBattery()
        {
            Console.WriteLine("HP INK 5 series is used");
        }
    }
}
