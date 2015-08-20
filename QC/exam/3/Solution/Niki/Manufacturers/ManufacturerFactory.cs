namespace Computers.Manufacturers
{
    using System;
    using System.Linq;
    using Exceptions;
    using Interfaces;

    public class ManufacturerFactory 
    {
        public ManufacturerFactory(Random random)
        {
            this.Random = random;
        }

        protected Random Random { get; set; }

        public IComputerManufacturer GetManufacturerFactory(string name)
        {
            IComputerManufacturer factory;

            if (name == "HP")
            {
                factory = new HpManufacturer(this.Random);
            }
            else if (name == "Dell")
            {
                factory = new DellManufacturer(this.Random);
            }
            else if (name == "Lenovo")
            {
                factory = new LenovoManufacturer(this.Random);
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            return factory;
        }
    }
}
