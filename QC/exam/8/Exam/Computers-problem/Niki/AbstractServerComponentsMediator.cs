namespace Computers.UI.Console
{
    using Computers.UI.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public abstract class AbstractServerComponentsMediator
    {
        public RAM Ram { get; set; }
        public CPU Cpu { get; set; }
        public VideoCard VideoCard { get; set; }

        public abstract void SaveDataToRam(int number);
        public abstract void GetDataFromRam();
        public abstract void GetResultFromCpu();
        public abstract string PrintResult(int data);
    }
}
