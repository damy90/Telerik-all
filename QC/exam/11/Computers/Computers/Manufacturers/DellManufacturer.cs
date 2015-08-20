using Computers.ComputerParts;
using Computers.ComputerParts.Processor;
using Computers.ComputerTypes;

namespace Computers.Manufacturers
{
    using System;

    public class DellManufacturer : Manufacturer
    {
        public override PersonalComputer ProducePersonalComputer()
        {
            return new PersonalComputer(new CentralProcessingUnitWith64Bits(FourGBits), new RamMemory(EightGBits), new SingleHardDrive(OneThousandGBits), new VideoCard());
        }

        public override Laptop ProduceLaptop()
        {
            return new Laptop(new CentralProcessingUnitWith32Bits(FourGBits), new RamMemory(EightGBits), new SingleHardDrive(OneThousandGBits), new VideoCard(), new LaptopBattery());
        }

        public override Server ProduceServer()
        {
            var raid = new RaidHardDrives();
            raid.Add(new SingleHardDrive(TwoThousandGBits));
            raid.Add(new SingleHardDrive(TwoThousandGBits));

            return new Server(new CentralProcessingUnitWith64Bits(EightGBits), new RamMemory(SixtyFourGBits), raid);
        }
    }
}
