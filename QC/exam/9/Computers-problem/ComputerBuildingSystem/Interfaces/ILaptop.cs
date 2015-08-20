namespace ComputerBuildingSystem.Interfaces
{
    using ComputerBuildingSystem;

    public interface ILaptop : IComputer
    {
        Battery Battery { get; set; }

        void ChargeBattery(int percentage);
    }
}
