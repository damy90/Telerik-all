namespace Computers.Interfaces
{
    public interface ICpu
    {
        byte NumberOfCores { get; set; }

        IMotherboard Motherboard { get; }

        void Rand(int a, int b);
        
        void SquareNumber();
    }
}
