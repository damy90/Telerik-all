namespace Computers
{
    using ComputerComponents;
    using Interfaces;
    using Enumarations;
    using System.Collections.Generic;

    public class Server : Computer, IComputer, IServer
    {
        private Motherboard motherBoard;

        public Server(ICpu initialCpu, Ram initialRam, IEnumerable<HardDrive> initialHardDrives, IVideoCard initialVideoCard)
            : base(ComputerType.PC, initialCpu, initialRam, initialHardDrives, initialVideoCard)
        {
            //this.motherBoard = new Motherboard();
        }

        public void Process(int data)
        {
            Ram.SaveValue(data);
            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}
