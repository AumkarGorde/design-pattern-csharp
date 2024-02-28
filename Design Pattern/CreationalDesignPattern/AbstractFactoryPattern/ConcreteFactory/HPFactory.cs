using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class HPFactory : ILaptopFactory
    {
        public BusinessLaptop CreateBusinessLaptop()
        {
            return new HPBusinessLaptop();
        }

        public GamingLaptop CreateGamingLaptop()
        {
            return new HPGamingLaptop();
        }
    }
}
