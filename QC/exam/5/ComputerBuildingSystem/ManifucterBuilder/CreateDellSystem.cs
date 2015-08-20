namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class CreateDellSystem : BuildComputerStrategy
    {
        public override ComputerTemplate BuildComputer()
        {
            var desctopRam = new ComputerRam(ComputerNumber);
            var desctopHardDrive = new ComputerHardDrive(false);
            var desctopCpu = new ComputerCpu(ComputerNumber / 2, 64, desctopRam, desctopHardDrive);
            var desctopHardDrives = new[] { new ComputerHardDrive(1000, false, 0) };
            var pc = new Computer(
                Type.PC,
                desctopCpu,
                desctopRam,
                desctopHardDrives,
                desctopHardDrive,
                null);

            var serverRam = new ComputerRam(ComputerNumber * ComputerNumber);
            var initServerHardDrives = new List<ComputerHardDrive>
            {
                new ComputerHardDrive(2000, false, 0),
                new ComputerHardDrive(2000, false, 0)
            };
            var serverHardDrive = new ComputerHardDrive(0, true, 2, initServerHardDrives);
            var serverCpu = new ComputerCpu(ComputerNumber, 64, serverRam, serverHardDrive);
            var serversHardDrives = new List<ComputerHardDrive> { serverHardDrive };
            var server = new Computer(
                Type.SERVER,
                serverCpu,
                serverRam,
                serversHardDrives,
                serverHardDrive,
                null);

            var laptopRam = new ComputerRam(ComputerNumber);
            var laptopVideoCard = new ComputerHardDrive(false);
            var laptopCpu = new ComputerCpu(ComputerNumber / 2, 32, laptopRam, laptopVideoCard);
            var laptopHardDrives = new[] { new ComputerHardDrive(1000, false, 0) };
            var laptopBattery = new LaptopBattery();
            var laptop = new Computer(
                Type.LAPTOP,
                laptopCpu,
                laptopRam,
                laptopHardDrives,
                laptopVideoCard,
                laptopBattery);

            return new ComputerTemplate(pc, laptop, server);
        }
    }
}
