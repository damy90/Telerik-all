namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class CreateLenovoSystem : BuildComputerStrategy
    {
        public override ComputerTemplate BuildComputer()
        {
            var desctopRam = new ComputerRam(ComputerNumber / 2);
            var desctopHardDrive = new ComputerHardDrive(false);
            var desctopCpu = new ComputerCpu(ComputerNumber / 4, 64, desctopRam, desctopHardDrive);
            var desctopHardDrives = new[]
            {
                new ComputerHardDrive(2000, false, 0)
            };
            var desctopComputer = new Computer(
                Type.PC,
                desctopCpu,
                desctopRam,
                desctopHardDrives,
                desctopHardDrive,
                null);

            var serverRam = new ComputerRam(ComputerNumber);
            var serverHardDrive = new ComputerHardDrive();
            var serverCpu = new ComputerCpu(ComputerNumber / 4, 128, serverRam, serverHardDrive);
            var serverHardDrives = new List<ComputerHardDrive>
            {
                new ComputerHardDrive(500, false, 0), 
                new ComputerHardDrive(500, false, 0)
            };
            var serverRaidHardDrive = new List<ComputerHardDrive>
            {
                new ComputerHardDrive(0, true, 2, serverHardDrives)
            };

            var server = new Computer(
                Type.SERVER,
                serverCpu,
                serverRam,
                serverRaidHardDrive,
                serverHardDrive,
                null);

            var laptopHardDrive = new ComputerHardDrive(false);
            var laptopRam = new ComputerRam(ComputerNumber * 2);
            var laptopCpu = new ComputerCpu(ComputerNumber / 4, 64, laptopRam, laptopHardDrive);
            var laptopHardDrives = new[]
            {
                new ComputerHardDrive(1000, false, 0)
            };
            var laptop = new Computer(
                Type.LAPTOP,
                laptopCpu,
                laptopRam,
                laptopHardDrives,
                laptopHardDrive,
                new LaptopBattery());

            return new ComputerTemplate(desctopComputer, laptop, server);
        }
    }
}
