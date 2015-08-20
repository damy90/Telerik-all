using System;
using System.Linq;

namespace _2.ItemsInPriceRange
{
    class Item: IComparable<Item>
    {
        public string Name;
        public double Price;

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Item(double price)
        {
            Name = "";
            Price = price;
        }

        public int CompareTo(Item other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("Item name: {0}, Item price: {1}", Name, Price);
        }
    }
}
