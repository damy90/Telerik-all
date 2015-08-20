namespace ComputerBuildingSystem.Computers
{
    using System.Collections.Generic;
    using ComputerBuildingSystem.Interfaces;

    public class Server : Computer, IServer
    {
        public Server(Cpu cpu, Ram ram, VideoCard videoCard, HardDriver hdd, IEnumerable<HardDriver> hardDrives)
            : base(cpu, ram, videoCard, hdd, hardDrives)
        {
            this.VideoCard.IsMonochrome = true;
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);
            Cpu.SquareNumber(this.Ram.Value);
        }
    }
}
