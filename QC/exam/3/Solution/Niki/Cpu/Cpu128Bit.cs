namespace Computers
{
    using System;
    using System.Linq;
    using Interfaces;

    public class Cpu128Bit : Cpu
    {
        private const int MinNumber = 0;
        private const int MaxNumber = 2000;

        public Cpu128Bit(byte numberOfCores, IMotherboard motherboard, Random random)
            : base(numberOfCores, 128, motherboard, random)
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
