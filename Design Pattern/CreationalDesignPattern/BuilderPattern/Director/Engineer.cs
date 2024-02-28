using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Engineer
    {
        private readonly IComputerBuilder _computerBuilder;
        public Engineer(IComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }

        public void AssembleComputer()
        {
            _computerBuilder.BuildCPU();
            _computerBuilder.BuildRAM();
            _computerBuilder.BuildGPU();
            _computerBuilder.BuildStorage();
        }

        public Computer GetComputer()
        {
           return _computerBuilder.GetComputer();
        }
        
    }
}
