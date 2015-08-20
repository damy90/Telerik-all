namespace Computers.Api
{
    using System;
    using System.Collections.Generic;

    public class Computer
    {
        private readonly LaptopBattery battery;

        public Computer(ComputerType type, Cpu cpu, RamMemory ram, IEnumerable<HardDriver> hardDrives, VideoCard videoCard, LaptopBattery battery)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            if (type != ComputerType.Laptop && type != ComputerType.Pc)
            {
                this.VideoCard.IsMonochrome = true;
            }

            this.battery = battery;
        }

        public IEnumerable<HardDriver> HardDrives { get; set; }

        public VideoCard VideoCard { get; set; }

        private Cpu Cpu { get; set; }

        private RamMemory Ram { get; set; }

        public void Play(int guessNumber)
        {
            this.Cpu.GenerateRandomNumber();
            var number = this.Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                VideoCard.Draw("You win!");
            }
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}%", this.battery.Percentage));
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);
            var result = Cpu.SquareNumber();
            this.VideoCard.Draw(result);
        }
    }
}