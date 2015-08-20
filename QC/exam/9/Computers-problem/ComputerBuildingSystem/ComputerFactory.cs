namespace ComputerBuildingSystem
{
    using ComputerBuildingSystem.Interfaces;

    public class ComputerFactory
    {
        private ComputerAbstractFactory factory;

        public ComputerFactory(ComputerAbstractFactory factory)
        {
            this.factory = factory;
        }

        public IPersonalComputer GetPersonalComputer()
        {
            return this.factory.MakePC();
        }

        public ILaptop GetLaptop()
        {
            return this.factory.MakeLaptop();
        }

        public IServer GetServer()
        {
            return this.factory.MakeServer();
        }
    }
}
