namespace ComputerBuildingSystem
{
    public class ManufacturerFactory
    {
        public Manufacturer GetManufacturer(string name)
        {
            Manufacturer manufacturer;
            if (name == "HP")
            {
                manufacturer = new HPManufacturer();               
            }
            else if (name == "Dell")
            {
                manufacturer = new DellManufacturer();        
            }
            else if (name == "Lenovo")
            {
                manufacturer = new LenovoManufacturer();
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            return manufacturer;
        }
    }
}
