namespace ComputersProgram
{
    using System;

    public class Cpu
    {
        public readonly int NumberOfBits;
        private static readonly Random Random = new Random();

        public Cpu(byte numberOfCores, int numberOfBits)
        {
            this.NumberOfBits = numberOfBits;
            this.NumberOfCores = numberOfCores;
        }

        private byte NumberOfCores { get; set; }

        public string SquareNumber(int number)
        {
            int maxPossibleNumber = 0;
            int bits = this.NumberOfBits;
            if (bits == 32)
            {
                maxPossibleNumber = 500;
            }
            else if (bits == 64)
            {
                maxPossibleNumber = 1000;
            }
            else if (bits == 128)
            {
                maxPossibleNumber = 2000;
            }
            else
            {
                return "Invalid number of CPU bits";
            }

            if (number < 0)
            {
                return "Number too low.";
            }

            if (number > maxPossibleNumber)
            {
                return "Number too high.";
            }

            int value = 0;
            for (int i = 0; i < number; i++)
            {
                value += number;
            }

            return string.Format("Square of {0} is {1}.", number, value);
        }

        public int GenerateRndInteger(int a, int b)
        {
            int randomNumber;
            randomNumber = Random.Next(a, b + 1);
            return randomNumber;
        }
    }
}
