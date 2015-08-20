namespace Cosmetics.Products
{
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Category : ICategory
    {
        private string name;
        public IList<IProduct> Products { get; private set; }

        private const int NameMinLength = 2;
        private const int NameMaxLength = 15;

        internal Category(string name)
        {
            this.Name = name;
            Products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Category name cannot be null");

                Validator.CheckIfStringLengthIsValid(
                    value,
                    NameMaxLength,
                    NameMinLength,
                    string.Format("Category name must be between {0} and {1} symbols long!",
                    NameMinLength,
                    NameMaxLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Product cannot be null");
            Products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Product cannot be null");
            Products.Remove(cosmetics);
        }

        public string Print()
        {
            // Who would want products sorted this way?
            var sortedProducts = Products.OrderBy(x => x.Brand)
                .ThenByDescending(x => x.Price);

            StringBuilder category = new StringBuilder();

            category.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name, this.Products.Count, this.Products.Count == 1 ? "product" : "products"));

            foreach (var product in sortedProducts)
            {
                category.AppendLine(product.Print());
            }

            return category.ToString().Trim();
        }
    }
}
