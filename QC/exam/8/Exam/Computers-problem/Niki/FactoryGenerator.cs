namespace Computers.UI.Console
{
    using Computers.UI.Console.AbstractComputerFactory;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FactoryGenerator
    {
        private static readonly Dictionary<string, IComputerFactory> factoryDictionary = new Dictionary<string, IComputerFactory>
        {
            {"HP", new HPComputerFactory()},
            {"Dell", new DellComputerFactory()}
        };

        public static IComputerFactory GetComputerFactory(string manufacturer) 
        {
            if (!factoryDictionary.Keys.Contains(manufacturer)) 
            {
                throw new ArgumentException("Invalid manufacturer!"); 
            }

            return factoryDictionary[manufacturer];
        }
    }
}
