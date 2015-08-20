using Computers.ComputerParts;
using Computers.Interfaces;

namespace Computers.Mediator
{
    using System;
    using System.Collections.Generic;

    public class Motherboard : IMotherboard
    {
        private readonly Dictionary<ComputerPartType, ComputerPart> participants =
            new Dictionary<ComputerPartType, ComputerPart>();

        public void Register(ComputerPart computerPart)
        {
            if (!this.participants.ContainsValue(computerPart))
            {
                this.participants[computerPart.ComputerPartType] = computerPart;
            }

            computerPart.Motherboard = this;
        }

        public void DrawOnVideoCard(string data)
        {
            var computerPart = this.participants[ComputerPartType.VideoCard];

            if (computerPart != null)
            {
                var videoCard = computerPart as VideoCard;
                videoCard.Draw(data);
            }
            else
            {
                throw new ArgumentNullException("There is no video card in this computer!");
            }
        }

        public int LoadRamValue()
        {
            var computerPart = this.participants[ComputerPartType.RamMemory];

            if (computerPart != null)
            {
                var ramMemory = computerPart as RamMemory;
                return ramMemory.LoadValue();
            }
            else
            {
                throw new ArgumentNullException("There is no ram memory in this computer!");
            }
        }

        public void SaveRamValue(int value)
        {
            var computerPart = this.participants[ComputerPartType.RamMemory];

            if (computerPart != null)
            {
                var ramMemory = computerPart as RamMemory;
                ramMemory.SaveValue(value);
            }
            else
            {
                throw new ArgumentNullException("There is no ram memory in this computer!");
            }
        }
    }
}
