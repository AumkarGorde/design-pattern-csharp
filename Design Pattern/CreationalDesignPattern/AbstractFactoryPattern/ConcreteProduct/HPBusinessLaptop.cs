using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class HPBusinessLaptop : BusinessLaptop
    {
        public override void LaptopProcessor()
        {
            Console.WriteLine("AMD processor is used");
        }
    }
}
