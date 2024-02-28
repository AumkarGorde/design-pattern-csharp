using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPlayGround
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine(" constructor of Parent");
        }
        static Parent()
        {
            Console.WriteLine("Static constructor of Parent");
        }
    }

    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine(" constructor of Child");
        }
        static Child()
        {
            Console.WriteLine("Static constructor of Child");
        }
    }
}
