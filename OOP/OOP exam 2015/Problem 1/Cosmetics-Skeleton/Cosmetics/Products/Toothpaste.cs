namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Linq;

    class Toothpaste : Product, IToothpaste
    {
        IList<string> ingredients=new List<string>();

        private const int IngredientMinLength = 4;
        private const int IngredientMaxLength = 12;

        internal Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients) : base(name, brand, price, gender)
        {
            this.SetIngredients = ingredients;
        }

        public IList<string> SetIngredients
        {
            set
            {
                Validator.CheckIfNull(value, "Ingredients cannot be null");

                foreach (var ingerdient in this.ingredients)
                {
                    Validator.CheckIfStringLengthIsValid(
                    ingerdient,
                    IngredientMaxLength,
                    IngredientMaxLength,
                    string.Format("Each ingredient must must be between {0} and {1} symbols long!",
                    IngredientMinLength,
                    IngredientMaxLength));
                }

                //var uniqueIngredients = new HashSet<string>(value);
                this.ingredients = value;
            }
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", ingredients);
            }
        }

        public override string Print()
        {
            var product = new StringBuilder(base.Print());
            product.AppendLine(string.Format("  * Ingredients: {0}", this.Ingredients));
            return product.ToString().TrimEnd();
        }
    }
}
