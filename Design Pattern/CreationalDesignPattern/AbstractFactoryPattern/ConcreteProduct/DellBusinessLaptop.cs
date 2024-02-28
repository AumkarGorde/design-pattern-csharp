using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class DellBusinessLaptop : BusinessLaptop
    {
        public override void LaptopProcessor()
        {
            Console.WriteLine("Intel i3 processor is used");
        }
    }
}
