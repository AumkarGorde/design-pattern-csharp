using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class BusinessLaptop
    {
        public abstract void LaptopProcessor();
        public void UseExcel()
        {
            Console.WriteLine("Sheets created..");
        }
    }
}
