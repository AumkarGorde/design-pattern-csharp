using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class DellFactory : ILaptopFactory
    {
        public BusinessLaptop CreateBusinessLaptop()
        {
            return new DellBusinessLaptop();
        }

        public GamingLaptop CreateGamingLaptop()
        {
            return new DellGamingLaptop();
        }
    }
}
