using Computers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class Cpu64Bit : Cpu
    {
        private const int MinNumber = 0;
        private const int MaxNumber = 1000;

        public Cpu64Bit(byte numberOfCores, IMotherboard motherboard, Random random)
            : base(numberOfCores, 64, motherboard, random)
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
