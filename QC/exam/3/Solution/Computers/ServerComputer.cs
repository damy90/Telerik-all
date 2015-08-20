using Computers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public class ServerComputer : Computer, IServerComputer
    {
        public ServerComputer(IMotherboard motherboard, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, IVideoCard videoCard)
            : base(ComputerType.SERVER, motherboard, cpu, ram, hardDrives, videoCard)
            {
            }

        public void Process(int data)
        {
            Ram.SaveValue(data);
            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}
