using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class PepperoniPizza : Pizza
    {
        internal override void Box()
        {
            Console.WriteLine("Pizza added to pepperoni pizza box");
        }

        internal override void Prepare()
        {
            Console.WriteLine("Pepperoni added..");
        }
    }
}
