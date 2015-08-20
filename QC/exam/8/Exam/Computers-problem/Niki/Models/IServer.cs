namespace Computers.UI.Console.AbstractComputerFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;

    public interface IServer : IComputer
    {
        AbstractServerComponentsMediator Mediator { get; set; }

        string Process(int data);
    }
}
