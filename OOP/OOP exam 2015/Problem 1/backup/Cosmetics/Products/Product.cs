namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        //TODO: check all invalid cases
        //TODO: all product constructors internal
        //Debugging exceptions is a nightmare on this.
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        private const int NameMinLength = 3;
        private const int NameMaxLength = 10;
        private const int BrandMinLength = 2;
        private const int BrandMaxLength = 10;

        public Product(string name, string brand, decimal price, GenderType gender)
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
                Validator.CheckIfStringIsNullOrEmpty(value);

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

        public string Print()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
