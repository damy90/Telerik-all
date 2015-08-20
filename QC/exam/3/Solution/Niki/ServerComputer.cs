namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class ServerComputer : Computer, IServerComputer
    {
        public ServerComputer(IMotherboard motherboard, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, IVideoCard videoCard)
            : base(ComputerType.SERVER, motherboard, cpu, ram, hardDrives, videoCard)
            {
            }

        public void Process(int data)
        {
            Ram.SaveValue(data);
            Cpu.SquareNumber();
        }
    }
}
