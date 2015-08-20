using Computers.UI.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.UI.Console
{
    public class ServerComponentsMediator : AbstractServerComponentsMediator
    {
        private const int MinNumberThatCanBeProcessed = 0;

        private int value;
        private int result;
        private Dictionary<int, int> maxAcceptableNumberDependingOnBits = new Dictionary<int, int>()
        {
            {32, 500},
            {64, 1000}
        };

        public ServerComponentsMediator(RAM ram, CPU cpu, VideoCard videoCard)
        {
            this.Ram = ram;
            this.Cpu = cpu;
            this.VideoCard = videoCard;
        }

        public override void SaveDataToRam(int number)
        {
            this.Ram.SaveValue(number);
        }

        public override void GetDataFromRam()
        {
            this.value = this.Ram.LoadValue();
        }

        public override void GetResultFromCpu()
        {
            this.result = this.Cpu.GetSquareNumber(this.value);
        }

        public override string PrintResult(int data)
        {
            var maxNumberThatCanBeProcessed = maxAcceptableNumberDependingOnBits[this.Cpu.NumberOfBits];

            SaveDataToRam(data);
            GetDataFromRam();

            if (this.value < MinNumberThatCanBeProcessed)
            {
                return "Number too low.";
            }
            else if (this.value > maxNumberThatCanBeProcessed)
            {
                return "Number too high.";
            }

            GetResultFromCpu();
            return string.Format("Square of {0} is {1}.", this.value, this.result);
        }
    }
}
