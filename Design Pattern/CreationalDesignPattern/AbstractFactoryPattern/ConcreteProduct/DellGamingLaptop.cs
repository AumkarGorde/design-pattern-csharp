using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class DellGamingLaptop : GamingLaptop
    {
        public override void LaptopBattery()
        {
            Console.WriteLine("Dell INS60 battery series is used");
        }
    }
}
