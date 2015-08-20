namespace ComputerBuildingSystem.Computers
{
    using System.Collections.Generic;
    using ComputerBuildingSystem.Interfaces;

    public class PersonalComputer : Computer, IPersonalComputer
    {
        public PersonalComputer(Cpu cpu, Ram ram, VideoCard videoCard, HardDriver hdd, IEnumerable<HardDriver> hardDrives)
            : base(cpu, ram, videoCard, hdd, hardDrives)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.GetRandomNumber(1, 10);
            var number = this.Ram.LoadValue();
            if (number != guessNumber)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }
    }
}
