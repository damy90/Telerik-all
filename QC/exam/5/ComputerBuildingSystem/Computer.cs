namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Computer
    {
        private readonly LaptopBattery battery;

        internal Computer(Type type, ComputerCpu cpu, ComputerRam ram, IEnumerable<ComputerHardDrive> hardDrives, ComputerHardDrive hardDrive, LaptopBattery battery)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.HardDrive = hardDrive;
            if (type == Type.SERVER)
            {
                this.HardDrive.IsMonochrome = true;
            }

            this.battery = battery;
        }

        internal IEnumerable<ComputerHardDrive> HardDrives { get; set; }

        internal ComputerHardDrive HardDrive { get; set; }

        internal ComputerCpu Cpu { get; set; }

        internal ComputerRam Ram { get; set; }

        internal void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.HardDrive.Draw(string.Format("Battery status: {0}%", this.battery.Percentage));
        }

        internal void Play(int guessNumber)
        {
            this.Cpu.Rand(1, 10);
            var number = this.Ram.LoadValue();
            if (number != guessNumber)
            {
                this.HardDrive.Draw(string.Format("You didn't guess the number {0}.", number));
                return;
            }

            this.HardDrive.Draw("You win!");
        }

        internal void Process(int data)
        {
            this.Ram.SaveValue(data);
            this.Cpu.SquareNumber();
        }
    }
}
