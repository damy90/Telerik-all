namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Text;

    class Shampoo : Product, IShampoo
    {
        private uint quantity;
        private UsageType usage;

        internal Shampoo(string name, string brand, decimal price, GenderType gender, uint quantity, UsageType usage) : base(name, brand, price, gender)
        {
            this.Milliliters = quantity;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get
            {
                return this.quantity;
            }
            private set
            {
                Validator.CheckIfNull(value);

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity cannot be negative!");
                }

                this.quantity = value;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }
            set
            {
                Validator.CheckIfNull(value);
                this.usage = value;
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price*this.Milliliters;
            }
            protected set
            {
                base.Price = value;
            }
        }

        public override string Print()
        {
            var product = new StringBuilder(base.Print());

            product.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            product.AppendLine(string.Format("  * Usage: {0}", this.Usage));

            return product.ToString().TrimEnd();
        }
    }
}
