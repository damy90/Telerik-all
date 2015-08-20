using Computers.Exceptions;
using Computers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.Manufacturers
{
    public class ManufacturerFactory 
    {
        protected Random random;

        public ManufacturerFactory(Random random)
        {
            this.random = random;
        }

        public IComputerManufacturer GetManufacturerFactory(string name)
        {
            IComputerManufacturer factory;

            if (name == "HP")
            {
                factory = new HpManufacturer(this.random);
            }
            else if (name == "Dell")
            {
                factory = new DellManufacturer(this.random);
            }
            else if (name == "Lenovo")
            {
                factory = new LenovoManufacturer(this.random);
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            return factory;
        }

    }
}
