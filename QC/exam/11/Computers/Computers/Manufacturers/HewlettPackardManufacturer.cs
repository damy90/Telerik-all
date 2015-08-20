using Computers.ComputerParts;
using Computers.ComputerParts.Processor;
using Computers.ComputerTypes;

namespace Computers.Manufacturers
{
    using System;

    public class HewlettPackardManufacturer : Manufacturer
    {
        public override PersonalComputer ProducePersonalComputer()
        {
            return new PersonalComputer(new CentralProcessingUnitWith32Bits(TwoGBits), new RamMemory(TwoGBits), new SingleHardDrive(FiveHundredGBits), new VideoCard());
        }

        public override Laptop ProduceLaptop()
        {
            return new Laptop(new CentralProcessingUnitWith64Bits(TwoGBits), new RamMemory(FourGBits), new SingleHardDrive(FiveHundredGBits), new VideoCard(), new LaptopBattery());
        }

        public override Server ProduceServer()
        {
            var raid = new RaidHardDrives();
            raid.Add(new SingleHardDrive(OneThousandGBits));
            raid.Add(new SingleHardDrive(OneThousandGBits));

            return new Server(new CentralProcessingUnitWith32Bits(FourGBits), new RamMemory(ThirtyTwoGBits), raid);
        }
    }
}
