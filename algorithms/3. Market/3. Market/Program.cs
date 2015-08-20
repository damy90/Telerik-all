using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace _3.Market
{
    class Program
    {
        static readonly HashSet<Product> store = new HashSet<Product>();
        static readonly Dictionary<string, HashSet<Product>> dictionary = new Dictionary<string, HashSet<Product>>();
        static readonly StringBuilder toPrint = new StringBuilder();

        static void Main(string[] args)
        {
            string command = null;
            var i = 0;
            while (command != "end")
            {
                command = Console.ReadLine();
                //Console.WriteLine(i++);
                CommandParserObjectImplementation(command);
            }

            Console.Write(toPrint);
        }

        static void CommandParserObjectImplementation(string command)
        {
            string[] commandParts = command.Split(' ');
            var commandName = commandParts[0];

            switch (commandName)
            {
                case "add":
                    //AddCommandObjectImplementation(commandParts);
                    AddCommandDictImplementation(commandParts);
                    break;
                case "filter":
                    FilterCommandObjectImplementation(commandParts);
                    break;

            }
        }

        static void AddCommandDictImplementation(string[] commandParts)
        {
            string name = commandParts[1];

            var countBeforeAdd = store.Count;

            var productToAdd = new Product(name, double.Parse(commandParts[2]));
            store.Add(productToAdd);

            if (countBeforeAdd == store.Count)
            {
                toPrint.AppendLine(string.Format("Error: Product {0} already exists", name));
                return;
            }

            toPrint.AppendLine("Ok: Product " + name + " added successfully");

            if (!dictionary.ContainsKey(commandParts[3]))
            {
                dictionary[commandParts[3]] = new HashSet<Product>();
            }

            dictionary[commandParts[3]].Add(productToAdd);
            return;
        }

        static void FilterCommandObjectImplementation(string[] commandParts)
        {
            string criteria = commandParts[2];
            IEnumerable<Product> result = new Bag<Product>();
            switch (criteria)
            {
                case "type":
                    //result = store.Where(p => p.Type == commandParts[3]);
                    if (!dictionary.ContainsKey(commandParts[3]))
                    {
                        toPrint.AppendLine(string.Format("Error: Type {0} does not exists", commandParts[3]));
                        return;
                    }
                    result = dictionary[commandParts[3]];

                    break;
                case "price":
                    string pticeCriteria = commandParts[3];
                    switch (pticeCriteria)
                    {
                        case "to":
                            result = store.Where(p => p.Price <= double.Parse(commandParts[4]));
                            break;
                        case "from":
                            // range
                            if (commandParts.GetLength(0) == 7)
                            {
                                result = store.TakeWhile(p => p.Price >= double.Parse(commandParts[4]))
                                    .Where(p => p.Price <= double.Parse(commandParts[6]));
                            }
                            else
                            {
                                result = store.Where(p => p.Price >= double.Parse(commandParts[4]));
                            }
                            break;
                    }
                    break;
            }
            //result.Sort();
            result = result
                .OrderBy(p => p)
                .Take(10);

            Bag<string> resultStrings = new Bag<string>();
            foreach (var item in result)
            {
                resultStrings.Add(string.Format("{0}({1})", item.Name, item.Price));
            }

            toPrint.AppendLine("Ok: " + string.Join(", ", resultStrings));
        }
    }

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        //public string Type { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            //data unchecked
            this.Name = name;
            //this.Type = type;
            this.Price = price;
        }

        public int CompareTo(Product other)
        {
            var priceCompareResult = this.Price.CompareTo(other.Price);
            if (priceCompareResult == 0)
            {
                return this.Name.CompareTo(other.Name);
            }

            return priceCompareResult;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((Name != null) ? this.Name.GetHashCode() : 0);
                //result = result * 23 + ((Type != null) ? this.Type.GetHashCode() : 0);
                result = result * 23 + ((Price != null) ? this.Price.GetHashCode() : 0);
                return result;
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                Product objAsProduct = (Product)obj;
                return this.Name == objAsProduct.Name;
            }
            catch (InvalidCastException)
            {
                return false;
            }
            //return base.Equals(obj);
        }
    }
}