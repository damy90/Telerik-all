namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ComputerBuildingSystemException : ArgumentException
    {
        public ComputerBuildingSystemException(string message)
            : base(message)
        {
        }
    }
}
