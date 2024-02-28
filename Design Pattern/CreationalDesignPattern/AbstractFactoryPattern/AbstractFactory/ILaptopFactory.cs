﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface ILaptopFactory
    {
        BusinessLaptop CreateBusinessLaptop();
        GamingLaptop CreateGamingLaptop();
    }
}
