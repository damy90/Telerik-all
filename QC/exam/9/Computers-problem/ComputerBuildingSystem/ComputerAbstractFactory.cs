namespace ComputerBuildingSystem
{
    using ComputerBuildingSystem.Computers;

    public abstract class ComputerAbstractFactory
    {
        public abstract PersonalComputer MakePC();

        public abstract Laptop MakeLaptop();

        public abstract Server MakeServer();
    }
}
