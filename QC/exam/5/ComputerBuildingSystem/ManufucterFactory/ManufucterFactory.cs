namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ManufucterFactory : IManufucterFactory
    {
        public BuildComputerStrategy GetManifucter(string manufacturer)
        {
            switch (manufacturer)
            {
                case "HP":
                    return new CreateHpSystem();
                case "Dell":
                    return new CreateDellSystem();
                case "Lenovo":
                    return new CreateLenovoSystem();
                default:
                    throw new ComputerBuildingSystemException("Invalid manufacturer!");
            }
        }
    }
}
