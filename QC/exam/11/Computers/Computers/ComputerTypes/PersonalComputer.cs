using Computers.ComputerParts;
using Computers.ComputerParts.Processor;
using Computers.Interfaces;

namespace Computers.ComputerTypes
{
    using System;

    public class PersonalComputer : Computer, IPlayable
    {
        private const int GameMinRandomNumber = 1;
        private const int GameMaxNumber = 11;

        public PersonalComputer(CentralProcessingUnit processor, RamMemory ramMemory, HardDrive hardDrives, VideoCard videoCard)
            : base(processor, ramMemory, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            var number = this.CentralProcessingUnit.GenerateRondomNumber(GameMinRandomNumber, GameMaxNumber, new Random());

            if (number != guessNumber)
            {
                VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                VideoCard.Draw("You win!");
            }
        }
    }
}