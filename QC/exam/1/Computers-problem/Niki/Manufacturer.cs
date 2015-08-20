namespace ComputerBuildingSystem
{
    public abstract class Manufacturer
    {
        public abstract PC GetPC();

        public abstract Server GetServer();

        public abstract Laptop GetLaptop();

        public abstract void GetAllProducts(out PC pc, out Server server, out Laptop laptop);
    }
}
