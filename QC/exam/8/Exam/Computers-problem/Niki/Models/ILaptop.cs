namespace Computers.UI.Console.AbstractComputerFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;

    public interface ILaptop : IComputer
    {
        LaptopBattery Battery { get; set; }

        string ChargeBattery(int percentage);
    }
}
