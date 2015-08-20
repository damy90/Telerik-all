namespace Computers.Api
{
    using System;

    public class Cpu
    {
        private static readonly Random Random = new Random();

        private readonly byte numberOfBits;

        private readonly RamMemory ram;

        public Cpu(byte numberOfCores, byte numberOfBits, RamMemory ram)
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
        }

        public byte NumberOfCores { get; set; }

        public void GenerateRandomNumber()
        {
            int randomNumber = Random.Next(0, 11);

            this.ram.SaveValue(randomNumber);
        }

        public string SquareNumber()
        {
            if (this.numberOfBits == 32)
            {
                return this.SquareNumber32();
            }

            if (this.numberOfBits == 64)
            {
                return this.SquareNumber64();
            }

            return "Invalid CPU";
        }

        private string SquareNumber32()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                return "Number too low.";
            }
            else if (data > 500)
            {
                return "Number too high.";
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                return string.Format("Square of {0} is {1}.", data, value);
            }
        }

        private string SquareNumber64()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                return "Number too low.";
            }
            else if (data > 1000)
            {
                return "Number too high.";
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                return string.Format("Square of {0} is {1}.", data, value);
            }
        }
    }
}