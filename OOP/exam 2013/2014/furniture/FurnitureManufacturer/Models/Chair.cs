namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    class Chair : Furniture, IChair
    {
        public int NumberOfLegs { get; protected set; }

        public Chair(string model, string material, decimal price, decimal heigth, int numberOfLegs)
            : base(model, material, price, heigth)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                this.GetType().Name,
                this.Model,
                this.Material, 
                this.Price, 
                this.Height, 
                this.NumberOfLegs);
        }
    }
}
