namespace Computers.Manufacturers
{
    using System;

    public class ManufacturerFactory
    {
        public static Manufacturer GetManufacturer(string manufacturerName)
        {
            switch (manufacturerName.ToUpper())
            {
                case "DELL":
                    return new DellManufacturer();
                case "HP":
                    return new HewlettPackardManufacturer();
                case "LENOVO":
                    return new LenovoManufacturer();
                default:
                    throw new ArgumentException("Invalid manufacturer!");
            }
        }
    }
}
