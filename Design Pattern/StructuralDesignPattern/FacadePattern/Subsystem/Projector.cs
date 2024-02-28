using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is on");
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            Console.WriteLine("Input is set to DVD player");
        }

        public void Off()
        {
            Console.WriteLine("Projector is off");
        }
    }
}
