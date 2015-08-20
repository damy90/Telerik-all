namespace Computers.UI.Console.Models
{
    using Computers.UI.Console.AbstractComputerFactory;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PersonalComputer : Computer, IComputer, IPersonalComputer
    {
        private const int GameMinNumber = 0;
        private const int GameMaxNumber = 10;

        public PersonalComputer(CPU cpu, RAM ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard) 
        {
            this.VideoCard.IsMonochrome = false;
        }

        public string GuessNumber(byte playerNumber)
        {
            var randomNumber = RandomGenerator.GenerateRandomNumber(GameMinNumber, GameMaxNumber);
            if (randomNumber == playerNumber) 
            {
               return "You win!";
            }

            return string.Format("You didn't guess the number {0}", randomNumber);
        }
    }
}
