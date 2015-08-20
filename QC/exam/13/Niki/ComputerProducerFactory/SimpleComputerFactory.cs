namespace ComputersProgram.ComputerProducerFactory
{
    public class SimpleComputerFactory
    {
        public AbstractComputerFactory CreateFactory(string brandName)
        {
            if (brandName == "HP")
            {
                return new HP();
            }
            else if (brandName == "Dell")
            {
                return new Dell();
            }
            else if (brandName == "Lenovo")
            {
                return new Lenovo();
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }
        }
    }
}
