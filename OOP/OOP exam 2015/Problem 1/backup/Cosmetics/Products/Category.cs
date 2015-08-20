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
        //TODO: Custom comparison in Product, use sorted list
        public IList<IProduct> Products { get; private set; }

        private const int NameMinLength = 2;
        private const int NameMaxLength = 15;

        public Category(string name)
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
                Validator.CheckIfStringIsNullOrEmpty(value);

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
            Validator.CheckIfNull(cosmetics);
            Products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
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
                category.AppendLine(string.Format("- {0} - {1}:", product.Brand, product.Name));
                category.AppendLine(string.Format("  * Price: ${0}", product.Price));
                category.AppendLine(string.Format("  * For gender: {0}", product.Gender));

                if (product is Toothpaste)
                {
                    var toothpaste = product as Toothpaste;
                    category.AppendLine(string.Format("  * Ingredients: {0}", toothpaste.Ingredients));
                }

                if (product is Shampoo)
                {
                    var shampoo = product as Shampoo;
                    category.AppendLine(string.Format("  * Quantity: {0} ml", shampoo.Milliliters));
                    category.AppendLine(string.Format("  * Usage: {0}", shampoo.Usage));
                }
            }

            return category.ToString().Trim();
        }
    }
}
