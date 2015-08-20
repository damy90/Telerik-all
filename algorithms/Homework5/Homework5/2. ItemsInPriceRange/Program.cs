using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Wintellect.PowerCollections;

namespace _2.ItemsInPriceRange
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedBag<Item> store = new OrderedBag<Item>();

            Random rnd = new Random();
            for (int i = 0; i < 500000; i++)
            {
                Item item = new Item("Product " + i, RandomPrice(rnd));
                store.Add(item);
            }

            var sw = new Stopwatch();
            sw.Start();

            IEnumerable<Item> searches = new List<Item>();
            for (int i = 0; i < 10000; i++)
            {
                double minPrice = RandomPrice(rnd);
                double maxPrice = RandomPrice(rnd);
                if (minPrice > maxPrice)
                {
                    double t = minPrice;
                    minPrice = maxPrice;
                    maxPrice = t;
                }

                searches = store.Range(new Item(minPrice), true, new Item(maxPrice), true).Take(20);
            }

            sw.Stop();

            Console.WriteLine("The time for 10 000 searches is:" + sw.Elapsed + "\nThe last result:\n" + string.Join("\n", searches));
        }

        private static double RandomPrice(Random rnd, double endValue = 1000000000)
        {
            return Math.Pow(rnd.NextDouble(), 4) * endValue;
        }
    }
}
