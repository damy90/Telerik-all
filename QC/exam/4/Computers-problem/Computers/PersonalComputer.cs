namespace Computers
{
    using ComputerComponents;
    using Enumarations;
    using Interfaces;
    using System.Collections.Generic;

    public class PersonalComputer : Computer, IComputer, IPersonalComputer
    {
        public PersonalComputer(ICpu initialCpu, Ram initialRam, IEnumerable<HardDrive> initialHardDrives, IVideoCard initialVideoCard)
            : base(ComputerType.PC, initialCpu, initialRam, initialHardDrives, initialVideoCard)
        {
        }

        public void Play(int guessNumber)
        {
            
            Cpu.Rand(1, 10);
            var number = Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                Cpu.Motherboard.DrawOnVideoCard(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                Cpu.Motherboard.DrawOnVideoCard("You win!");
            }
        }
    }
}
