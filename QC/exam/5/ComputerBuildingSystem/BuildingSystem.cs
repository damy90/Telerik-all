namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using ComputerBuildingSystem;

    public class BuildingSystem
    {
        public void Create()
        {
            var manufacturer = Console.ReadLine();
            IManufucterFactory manufucterFactory = new ManufucterFactory();
            BuildComputerStrategy createSystem = manufucterFactory.GetManifucter(manufacturer);
            ComputerTemplate computerData = createSystem.BuildComputer();

            while (true)
            {
                var currentLine = Console.ReadLine();
                if (string.IsNullOrEmpty(currentLine) || currentLine.StartsWith("Exit"))
                {
                    break;
                }

                var parameters = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (parameters.Length != 2)
                {
                    throw new ComputerBuildingSystemException("Invalid length of attribute");
                }

                var commandParameter = parameters[0];
                var commandAtribute = int.Parse(parameters[1]);
                ICommandFactory executeCoomand = new ExecuteCommand(computerData);
                executeCoomand.Execute(commandParameter, commandAtribute);
            }
        }
    }
}
