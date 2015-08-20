namespace Computers.UI.Console.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IComputer
    {
        VideoCard VideoCard { get; set; }
        CPU Cpu { get; set; }
        RAM Ram { get; set; }
        IEnumerable<HardDrive> HardDrives { get; set; }
    }
}
