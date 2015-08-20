namespace ComputersProgram
{
    using System;

    public static class ProgramCommandControl
    {
        public static void Start()
        {
            while (true)
            {
                string readLine = Console.ReadLine();
                if (readLine == null)
                {
                    break;
                }

                if (readLine.StartsWith("Exit"))
                {
                    break;
                }

                string[] commandInfo = readLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandInfo.Length != 2)
                {                   
                     throw new ArgumentException("Invalid command!");                    
                }

                string commandName = commandInfo[0];
                int commandArgument = int.Parse(commandInfo[1]);

                if (commandName == "Charge")
                {
                    Computers.Laptop.ChargeBattery(commandArgument);
                }
                else if (commandName == "Process")
                {
                    Computers.Server.Process(commandArgument);
                }
                else if (commandName == "Play")
                {
                    Computers.Pc.Play(commandArgument);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}
