namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class ShoppingCart : IShoppingCart
    {
        public IList<IProduct> Products { get; private set; }

        public ShoppingCart()
        {
            Products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            Products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            Products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            return Products.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal result = 0;

            foreach (var product in Products)
            {
                result += product.Price;
            }

            return result;
        }
    }
}
