namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal abstract class BuildComputerStrategy
    {
        protected const int ComputerNumber = 8;

        public abstract ComputerTemplate BuildComputer();
    }
}
