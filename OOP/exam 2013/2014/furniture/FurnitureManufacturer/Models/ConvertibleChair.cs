namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;

        public ConvertibleChair(string model, string material, decimal price, decimal heigth, int numberOfLegs)
            : base(model, material, price, heigth, numberOfLegs)
        {
        }

        public bool IsConverted
        {
            get
            {
                return isConverted;
            }
        }

        public void Convert()
        {
            isConverted = !isConverted;
        }

        public override decimal Height
        {
            get
            {
                if (isConverted)
                {
                    return 0.10m;
                }

                return base.Height;
            }
            protected set
            {
                
                base.Height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, State: {1}", base.ToString(), this.IsConverted ? "Converted" : "Normal");
        }
    }
}
