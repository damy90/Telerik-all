namespace Computers.UI.Console.Models
{
    using Computers.UI.Console.AbstractComputerFactory;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Server : Computer, IComputer, IServer
    {

        public Server(CPU cpu, RAM ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.VideoCard.IsMonochrome = true;
            this.Mediator = new ServerComponentsMediator(this.Ram, this.Cpu, this.VideoCard);
        }

        public AbstractServerComponentsMediator Mediator { get; set; }

        public string Process(int data)
        {
            var result = this.Mediator.PrintResult(data);
            return string.Format("Square of {0} is {1}.", data, result);
        }
    }
}
