namespace Computers
{
    using System;
    using System.Linq;
    using Interfaces;

    public class Cpu32Bit : Cpu
    {
        private const int MinNumber = 0;
        private const int MaxNumber = 500;

        public Cpu32Bit(byte numberOfCores, IMotherboard motherboard, Random random)
            : base(numberOfCores, 32, motherboard, random)
        {
        }

        protected override int MinAllowedValue
        {
            get
            {
                return MinNumber;
            }
        }

        protected override int MaxAllowedValue
        {
            get
            {
                return MaxNumber;
            }
        }
    }
}
