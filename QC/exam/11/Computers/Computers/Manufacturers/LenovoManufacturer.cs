using Computers.ComputerParts;
using Computers.ComputerParts.Processor;
using Computers.ComputerTypes;
using Computers.DrawerStrategy;

namespace Computers.Manufacturers
{
    public class LenovoManufacturer : Manufacturer
    {
        public override PersonalComputer ProducePersonalComputer()
        {
            return new PersonalComputer(new CentralProcessingUnitWith64Bits(TwoGBits), new RamMemory(FourGBits), new SingleHardDrive(TwoThousandGBits), new VideoCard(new MonochromeDrawer()));
        }

        public override Laptop ProduceLaptop()
        {
            return new Laptop(new CentralProcessingUnitWith64Bits(TwoGBits), new RamMemory(SixteenGBits), new SingleHardDrive(OneThousandGBits), new VideoCard(), new LaptopBattery());
        }

        public override Server ProduceServer()
        {
            var raid = new RaidHardDrives();
            raid.Add(new SingleHardDrive(FiveHundredGBits));
            raid.Add(new SingleHardDrive(FiveHundredGBits));

            return new Server(new CentralProcessingUnitWith128Bits(TwoGBits), new RamMemory(EightGBits), raid);
        }
    }
}
