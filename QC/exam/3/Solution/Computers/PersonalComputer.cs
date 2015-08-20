namespace Computers
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class PersonalComputer : Computer, IPersonalComputer
    {
        private const int MinRandomValue = 1;
        private const int MaxRandomValue = 10;

        public PersonalComputer(IMotherboard motherboard, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, IVideoCard videoCard)
            : base(ComputerType.PC, motherboard, cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            this.Cpu.GenerateRandomNumber(MinRandomValue, MaxRandomValue);
            int number = this.Motherboard.LoadRamValue();
            if (number != guessNumber)
            {
                this.Motherboard.DrawOnVideoCard(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.Motherboard.DrawOnVideoCard("You win!");
            }
        }
    }
}
