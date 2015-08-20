using Computers.UI.Console.Models;
namespace Computers.UI.Console
{
    using System;
    using Models;

    public class CPU
    {
        private const int MinNumberThatCanBeProcessed = 0;
        private byte numberOfBits;
        private byte numberOfCores;
        static Random Random = new Random();

        internal CPU(byte numberOfCores, byte numberOfBits)
        {
            this.NumberOfBits = numberOfBits;
            this.numberOfCores = numberOfCores;
        }

        public byte NumberOfBits
        {
            get
            {
                return this.numberOfBits;
            }

            set
            {
                if (value != 32 && value != 64)
                {
                    throw new ArgumentException("Number of bits can only be 32 or 64"); // TODO: enum this (eventually)
                }
                this.numberOfBits = value;
            }
        }

        public int GetSquareNumber(int number)
        {
            int result = number * number;
            return result;
        }
    }
}
