namespace Computers
{
    using System;

    public class Cpu
    {
        private readonly byte numberOfBits;

        private readonly Ram ram;

        private readonly VideoCard videoCard;

        private readonly Random randomGen = new Random();

        public Cpu(byte numberOfCores, byte numberOfBits, Ram ram, VideoCard videoCard) 
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        public byte NumberOfCores { get; private set; }

        public void SquareNumber()
        {
            int max;
            if (this.numberOfBits == 32) 
            { 
                max = 500; 
            }
            else if (this.numberOfBits == 64) 
            { 
                max = 1000; 
            }
            else if (this.numberOfBits == 128) 
            { 
                max = 2000; 
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation for this CPU.");
            }

            this.SquareNumberProtected(max);
        }

        public void RandAndSave(int a, int b)
        {
            int randomNumber = this.randomGen.Next(a, b + 1);

            this.ram.SaveValue(randomNumber);
        }

        private void SquareNumberProtected(int maxInput)
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > maxInput)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int result = data * data;
                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, result));
            }
        }
    }
}
