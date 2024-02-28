using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal abstract class Pizza
    {
        internal abstract void Prepare();
        internal abstract void Box();
        internal virtual void Cut()
        {
            Console.WriteLine("Pizza is cut in four peices");
        }
        internal virtual void Bake()
        {
            Console.WriteLine("Pizza is being baked..");
        }

    }
}
