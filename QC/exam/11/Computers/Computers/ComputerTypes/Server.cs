using Computers.ComputerParts;
using Computers.ComputerParts.Processor;
using Computers.DrawerStrategy;
using Computers.Interfaces;

namespace Computers.ComputerTypes
{
    using System;

    public class Server : Computer, IProcessable
    {
        public Server(CentralProcessingUnit processor, RamMemory ramMemory, HardDrive hardDrives)
            : base(processor, ramMemory, hardDrives, new VideoCard(new MonochromeDrawer()))
        {
        }

        public void Process(int data)
        {
            this.RamMemory.SaveValue(data);
            this.CentralProcessingUnit.CalculateSquareNumber();
        }
    }
}
