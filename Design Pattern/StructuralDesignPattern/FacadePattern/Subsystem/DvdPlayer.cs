using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD player is on");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Playing {movie}");
        }

        public void Stop()
        {
            Console.WriteLine("DVD player stopped");
        }
    }
}
