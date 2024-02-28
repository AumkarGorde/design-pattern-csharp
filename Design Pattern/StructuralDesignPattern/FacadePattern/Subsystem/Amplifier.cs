using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            Console.WriteLine("DVD player is set");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Surround sound is set");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is off");
        }
    }
}
