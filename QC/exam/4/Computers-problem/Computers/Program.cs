namespace Computers
{
    using System;
    using Enumarations;
    using Manufacturers;
    using Interfaces;
    using Exceptions;

    public class Computers
    {
        public static void Main()
        {
            IPersonalComputer pc;
            ILaptop laptop;
            IServer server;

            var manufacturerName = Console.ReadLine();
            if (manufacturerName == "HP")
            {
                IManufacturer manufacturer = new HP();

                pc = (IPersonalComputer)manufacturer.Manufacture(ComputerType.PC);

                server = (IServer)manufacturer.Manufacture(ComputerType.Server);

                laptop = (ILaptop)manufacturer.Manufacture(ComputerType.Laptop);
            }
            else if (manufacturerName == "Dell")
            {
                IManufacturer manufacturer = new Dell();

                pc = (IPersonalComputer)manufacturer.Manufacture(ComputerType.PC);
                server = (IServer)manufacturer.Manufacture(ComputerType.Server);
                laptop = (ILaptop)manufacturer.Manufacture(ComputerType.Laptop);
            }
            else if (manufacturerName == "Lenovo")
            {
                IManufacturer manufacturer = new Lenovo();

                pc = (IPersonalComputer)manufacturer.Manufacture(ComputerType.PC);
                server = (IServer)manufacturer.Manufacture(ComputerType.Server);
                laptop = (ILaptop)manufacturer.Manufacture(ComputerType.Laptop);
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var c = Console.ReadLine();
                if (c == null)
                {
                    break;
                }

                if (c.StartsWith("Exit"))
                {
                    break;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cp.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var cn = cp[0];
                var ca = int.Parse(cp[1]);

                if (cn == "Charge")
                {
                    laptop.ChargeBattery(ca);
                }
                else if (cn == "Process")
                {
                    server.Process(ca);
                }
                else if (cn == "Play")
                {
                    pc.Play(ca); ;
                }
            }
        }        
    }
}