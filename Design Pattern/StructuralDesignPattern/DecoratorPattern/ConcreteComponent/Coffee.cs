﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Coffee : ICoffee
    {
        public double GetCost()
        {
            return 1.0;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
