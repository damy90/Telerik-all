namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;

    class Shampoo : Product, IShampoo
    {
        private uint quantity;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint quantity, UsageType usage) : base(name, brand, price, gender)
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
    }
}
