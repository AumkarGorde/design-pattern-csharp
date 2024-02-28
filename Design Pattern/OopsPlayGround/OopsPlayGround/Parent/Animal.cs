using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPlayGround
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Parent constructor");
        }

        static Animal()
        {
            Console.WriteLine("Parent static constructor");
        }
        public void Sound()
        {
            Console.WriteLine("Animal makes sound");
        }

        public void Run()
        {
            Console.WriteLine("Animal is running");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Animal stopped");
        }

        public virtual void Sleep() 
        {
            Console.WriteLine("Animal sleeping");
        }
    }
}
