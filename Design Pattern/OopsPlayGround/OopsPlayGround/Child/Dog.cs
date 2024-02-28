using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPlayGround
{
    public class Dog : Animal
    {
        public Dog() 
        {
            Console.WriteLine("Child constructor");
        }

        static Dog()
        {
            Console.WriteLine("Child Static constructor");
        }

        public void Sound()
        {
            Console.WriteLine("dog makes sound");
        }

        public new void Run()
        {
            Console.WriteLine("dog is running");
        }

        public override void Stop()
        {
            Console.WriteLine("dog stopped");
        }

        public void Sleep()
        {
            Console.WriteLine("dog sleeping");
        }

        public void DogSpecificMethod()
        {
            Console.WriteLine("Dog specific");
        }
    }
}
