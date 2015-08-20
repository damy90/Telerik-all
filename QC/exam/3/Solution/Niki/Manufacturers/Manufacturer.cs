namespace Computers.Manufacturers
{
    using System;
    using System.Linq;
    using Interfaces;

    public abstract class Manufacturer : IComputerManufacturer
    {
        public Manufacturer(Random random)
        {
            this.Random = random;
        }

        protected Random Random { get; set; }

        public abstract IPersonalComputer MakePersonalComputer();

        public abstract ILaptopComputer MakeLaptopComputer();

        public abstract IServerComputer MakeSeverComputer();
    }
}
