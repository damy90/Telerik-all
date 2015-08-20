using Computers.Mediator;

namespace Computers.ComputerParts
{
    public abstract class ComputerPart
    {
        public ComputerPart(ComputerPartType computerType)
        {
            this.ComputerPartType = computerType;
        }

        public ComputerPartType ComputerPartType { get; set; }

        public Motherboard Motherboard { get; set; }
    }
}
