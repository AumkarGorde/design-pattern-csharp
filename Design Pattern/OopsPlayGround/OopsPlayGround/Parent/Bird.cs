using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPlayGround
{
    public class Bird : IFly
    {
        public string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("Fly !!");
        }
    }

    public interface IFly
    {
        void Fly();
    }
}
