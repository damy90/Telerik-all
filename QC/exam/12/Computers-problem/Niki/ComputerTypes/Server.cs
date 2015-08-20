namespace Computers.ComputerTypes
{
    using System;
    using Computers.Contracts;

    public class Server : Computer
    {
        public Server(Cpu cpu, Ram ram, IStorageDevice hardDrives, VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
            if (videoCard.IsMonochrome == false)
            {
                throw new ArgumentException("Cannot initialise server with colourful video card");
            }
        }

        internal void Process(int data)
        {
            Ram.SaveValue(data);
            CPU.SquareNumber();
        }
    }
}
