namespace Computers.Interfaces
{
    using Enumarations;

    public interface IManufacturer
    {
        IComputer Manufacture(ComputerType type);
    }
}
