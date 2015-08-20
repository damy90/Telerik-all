namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;

    public abstract class Product : IProduct
    {
        //Debugging exceptions is a nightmare on this.
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        private const int NameMinLength = 3;
        private const int NameMaxLength = 10;
        private const int BrandMinLength = 2;
        private const int BrandMaxLength = 10;

        internal Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            //this.Gender = (GenderType)Enum.Parse(typeof(GenderType), gender);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Product name cannot be null");

                Validator.CheckIfStringLengthIsValid(
                    value,
                    NameMaxLength,
                    NameMinLength,
                    string.Format("Product name must be between {0} and {1} symbols long!",
                    NameMinLength,
                    NameMaxLength));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Brand cannot be null!"); // You just hat to reinvent the wheel

                // first max then min? it's your fault if I mix them!
                Validator.CheckIfStringLengthIsValid(
                    value,
                    NameMaxLength,
                    NameMinLength,
                    string.Format("Product brand must be between {0} and {1} symbols long!",
                    BrandMinLength,
                    BrandMaxLength));

                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                Validator.CheckIfNull(value, "Price cannot be null!");

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }

                this.price = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            {
                Validator.CheckIfNull(value, "Gender cannot be null!");
                this.gender = value;
            }
        }

        public virtual string Print()
        {
            var product = new StringBuilder();

            product.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            product.AppendLine(string.Format("  * Price: ${0}", this.Price));
            product.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            return product.ToString();
        }
    }
}
