namespace ComputersProgram
{
    using System.Collections.Generic;

    public class Computer
    {
        private readonly LaptopBattery battery;
        private readonly MotherBoard motherBoard;
        private string type;   

        internal Computer(
            string type,
            Cpu cpu,
            RAMMemory ram,
            IEnumerable<HardDriver> hardDrives,
            IVideoCard videoCard,
            LaptopBattery battery)
        {
            this.type = type;
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;

            this.battery = battery;
            this.motherBoard = new MotherBoard(this.Cpu, this.Ram, this.VideoCard);
        }

        private IEnumerable<HardDriver> HardDrives { get; set; }

        private IVideoCard VideoCard { get; set; }

        private Cpu Cpu { get; set; }

        private RAMMemory Ram { get; set; }

        public void Play(int guessNumber)
        {
            int rndNumber = this.Cpu.GenerateRndInteger(1, 10);
            this.motherBoard.SaveRamValue(rndNumber);
            int number = this.motherBoard.LoadRamValue();
            if (number == guessNumber)
            {
                this.motherBoard.DrawOnVideoCard("You win!");
            }
            else
            {
                this.motherBoard.DrawOnVideoCard(string.Format("You didn't guess the number {0}.", number));
            }
        }

        internal void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}%", this.battery.Percentage));
        }

        internal void Process(int number)
        {
            this.motherBoard.SaveRamValue(number);
            string processAnswer = this.Cpu.SquareNumber(this.motherBoard.LoadRamValue());
            this.motherBoard.DrawOnVideoCard(processAnswer);
        }

        private void Print(string text)
        {
            this.motherBoard.DrawOnVideoCard(text);
        }
    }
}