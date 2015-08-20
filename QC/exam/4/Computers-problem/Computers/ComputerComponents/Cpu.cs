namespace Computers.ComputerComponents
{
    using System;
    using Enumarations;
    using Interfaces;

    public class Cpu : ICpu
    {
        private static readonly Random Random = new Random();

        private readonly byte numberOfBits;

        private IMotherboard motherboard;

        public Cpu(byte numberOfCores, CpuType numberOfBits, IMotherboard motherboard) 
        {
            this.numberOfBits = (byte)numberOfBits;
            this.NumberOfCores = numberOfCores;
            this.motherboard = motherboard;
        }

        public byte NumberOfCores { get; set; }

        public IMotherboard Motherboard
        {
            get
            {
                return this.motherboard;
            }
        }

        public virtual void SquareNumber()
        {
            int max;
            if (this.numberOfBits == 32)
            {
                max = 500;
            }
            else
            {
                max = 1000;
            }

            var data = this.motherboard.LoadRamValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > max)
            {
                this.motherboard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.motherboard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        public void Rand(int a, int b)
        {
            int randomNumber = Random.Next(a, b + 1);
            this.motherboard.SaveRamValue(randomNumber);
        }
    }
}
