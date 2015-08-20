namespace ComputerBuildingSystem
{
    using System;

    public class ComputerCpu
    {
        private readonly byte numberOfBits;
        private readonly ComputerRam ram;
        private readonly ComputerHardDrive computerHardDrive;

        public ComputerCpu(byte numberOfCores, byte numberOfBits, ComputerRam ram, ComputerHardDrive hardDrive)
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.computerHardDrive = hardDrive;
        }

        public byte NumberOfCores { get; set; }

        public ComputerHardDrive HardDrive
        {
            get { return this.computerHardDrive; }
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
        }

        public void SquareNumber32()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.HardDrive.Draw("Number too low.");
            }
            else if (data > 500)
            {
                this.HardDrive.Draw("Number too high.");
            }
            else
            {
                var value = CalculateValueOfSquare(data);

                this.HardDrive.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        public void SquareNumber64()
        {
            var data = this.ram.LoadValue();
            if (data < 0)
            {
                this.HardDrive.Draw("Number too low.");
            }
            else if (data > 1000)
            {
                this.HardDrive.Draw("Number too high.");
            }
            else
            {
                var value = CalculateValueOfSquare(data);
                this.HardDrive.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        public int Rand(int firstNumber, int secondNumber)
        {
            var random = new Random();
            try
            {
                var randomNumber = random.Next(firstNumber, secondNumber);
                this.ram.SaveValue(randomNumber);
                return randomNumber;
            }
            catch (Exception e)
            {
                throw new ComputerBuildingSystemException(string.Format("Error when calculate random number: {0}", e.Message));
            }
        }

        private static int CalculateValueOfSquare(int data)
        {
            int value = 0;
            for (int i = 0; i < data; i++)
            {
                value += data;
            }

            return value;
        }
    }
}
