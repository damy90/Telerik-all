namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ExecuteCommand : ICommandFactory
    {
        private readonly ComputerTemplate computerData;

        public ExecuteCommand(ComputerTemplate computerData)
        {
            this.computerData = computerData;
        }

        public void Execute(string command, int commandAtribute)
        {
            switch (command)
            {
                case "Charge":
                    this.computerData.LaptopComputer.ChargeBattery(commandAtribute);
                    break;
                case "Process":
                    this.computerData.ServerComputer.Process(commandAtribute);
                    break;
                case "Play":
                    this.computerData.DesctopComputer.Play(commandAtribute);
                    break;
                default:
                    throw new ComputerBuildingSystemException(string.Format("Invalid command :{0}", command));
            }
        }
    }
}
