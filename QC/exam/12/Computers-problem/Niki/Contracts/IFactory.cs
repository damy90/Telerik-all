namespace Computers.Contracts
{
    using Computers.ComputerTypes;

    public interface IFactory
    {
        PC CreatePC();

        Server CreateServer();

        Laptop CreateLaptop();
    }
}
