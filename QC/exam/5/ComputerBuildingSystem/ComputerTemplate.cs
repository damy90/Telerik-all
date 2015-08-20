namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ComputerTemplate
    {
        private readonly Computer desktopComputer;
        private readonly Computer serverComputer;
        private readonly Computer laptopComputer;

        public ComputerTemplate(Computer dekstop, Computer laptop, Computer server)
        {
            this.desktopComputer = dekstop;
            this.serverComputer = server;
            this.laptopComputer = laptop;
        }

        public Computer DesctopComputer
        {
            get
            {
                return this.desktopComputer;
            }
        }

        public Computer ServerComputer
        {
            get
            {
                return this.serverComputer;
            }
        }

        public Computer LaptopComputer
        {
            get
            {
                return this.laptopComputer;
            }
        }
    }
}
