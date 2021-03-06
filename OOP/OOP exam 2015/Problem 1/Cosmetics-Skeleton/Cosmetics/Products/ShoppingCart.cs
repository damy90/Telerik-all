﻿namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class ShoppingCart : IShoppingCart
    {
        public IList<IProduct> Products { get; private set; }

        internal ShoppingCart()
        {
            Products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "Product cannot be null");
            Products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "Product cannot be null");
            Products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "Product cannot be null");
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
