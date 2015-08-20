using Computers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Manufacturers
{
    public abstract class Manufacturer : IComputerManufacturer
    {
        protected Random random;

        public Manufacturer(Random random)
        {
            this.random = random;
        }
        public abstract IPersonalComputer MakePersonalComputer();


        public abstract ILaptopComputer MakeLaptopComputer();

        public abstract IServerComputer MakeSeverComputer();
    }
}
