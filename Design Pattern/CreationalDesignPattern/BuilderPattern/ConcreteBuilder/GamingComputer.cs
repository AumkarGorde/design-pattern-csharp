using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class GamingComputer : IComputerBuilder
    {
        private Computer computer;
        public GamingComputer()
        {
            computer = new Computer();
        }
        public void BuildCPU()
        {
            computer.CPU = "Intel Core i9";
        }

        public void BuildGPU()
        {
            computer.GPU = "NVIDIA GeForce RTX 3080";
        }

        public void BuildRAM()
        {
            computer.RAM = "32GB DDR4";
        }

        public void BuildStorage()
        {
            computer.Storage = "1TB SSD + 2TB HDD";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
