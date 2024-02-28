using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            
        }
        internal override void Box()
        {
            Console.WriteLine("Pizza added to Cheese Pizza Box");
        }

        internal override void Prepare()
        {
            Console.WriteLine("Cheese added");
        }
    }
}
