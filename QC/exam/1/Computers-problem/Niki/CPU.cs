namespace ComputerBuildingSystem
{
    using System;

    public class CPU
    {
        private static readonly Random Random = new Random();

        private readonly byte numberOfBits;

        private IMotherboard motherboard;

        public CPU(byte numberOfCores, byte numberOfBits, IMotherboard motherboard) 
        {
            this.numberOfBits = numberOfBits;         
            this.NumberOfCores = numberOfCores;
            this.motherboard = motherboard;
        }

        public byte NumberOfCores { get; set; }

        public void Rand(int a, int b)
        {
            int randomNumber;
            do
            {
                randomNumber = Random.Next(0, 1000);
            }
            while (!(randomNumber >= a && randomNumber <= b));
            this.motherboard.SaveRAMValue(randomNumber);
        }

        public void SquareNumber()
        {
            if (this.numberOfBits == 32)
            {
                this.SquareNumber32();
            }

            if (this.numberOfBits == 64)
            {
                this.SquareNumber64();
            }

            if (this.numberOfBits == 128)
            {
                this.SquareNumber128();
            }
        }

        private void SquareNumber32()
        {
            var data = this.motherboard.LoadRAMValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > 500)
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

        private void SquareNumber64()
        {
            var data = this.motherboard.LoadRAMValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > 1000)
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

        private void SquareNumber128()
        {
            var data = this.motherboard.LoadRAMValue();
            if (data < 0)
            {
                this.motherboard.DrawOnVideoCard("Number too low.");
            }
            else if (data > 2000)
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
    }
}
