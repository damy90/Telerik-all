using Computers.ComputerParts;
using Computers.ComputerParts.Processor;
using Computers.Interfaces;

namespace Computers.ComputerTypes
{
    using System;

    public class Laptop : Computer, IChargeable
    {
        public Laptop(CentralProcessingUnit processor, RamMemory ramMemory, HardDrive hardDrives, VideoCard videoCard, LaptopBattery battery)
            : base(processor, ramMemory, hardDrives, videoCard)
        {
            this.Battery = battery;
        }

        public LaptopBattery Battery { get; private set; }

        public void ChargeBattery(int percentage)
        {
            this.Battery.ChargeBattery(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}%", this.Battery.CurrentBatteryLife));
        }
    }
}