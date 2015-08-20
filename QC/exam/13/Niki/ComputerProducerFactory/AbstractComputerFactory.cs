namespace ComputersProgram.ComputerProducerFactory
{
    public abstract class AbstractComputerFactory
    {
        public abstract Computer MakeLaptop();

        public abstract Computer MakePC();

        public abstract Computer MakeServer();
    }
}
