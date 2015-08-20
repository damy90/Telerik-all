using System;
using System.Collections.Generic;

namespace _1.KnapsackProblem
{
    public class Program
    {
        public static void Main()
        {
            /*var items = new List<Item>(){
                new Item("Apple", 39, 40, 4),
                new Item("Banana", 27, 60, 4),
                new Item("Beer", 52, 10, 12),
                new Item("Book", 30, 10, 2),
                new Item("Camera", 32, 30, 1),
                new Item("Cheese", 23, 30, 4),
                new Item("Chocolate Bar", 15, 60, 10),
                new Item("Compass", 13, 35, 1),
                new Item("Jeans", 48, 10, 1),
                new Item("Map", 9, 150, 1),
                new Item("Notebook", 22, 80, 1),
                new Item("Sandwich", 50, 160, 4),
                new Item("Ski Jacket", 43, 75, 1),
                new Item("Ski Pants", 42, 70, 1),
                new Item("Socks", 4, 50, 2),
                new Item("Sunglasses", 7, 20, 1),
                new Item("Suntan Lotion", 11, 70, 1),
                new Item("T-Shirt", 24, 15, 1),
                new Item("Tin", 68, 45, 1),
                new Item("Towel", 18, 12, 1),
                new Item("Umbrella", 73, 40, 1),
                new Item("Water", 153, 200, 1)
            };*/

            //int capacity = 1000;

            var items = new List<Item>(){
                new Item("beer", 3, 2, 1),
                new Item("vodka", 8, 12, 1),
                new Item("cheese", 4, 5, 1),
                new Item("nuts", 1, 4, 1),
                new Item("ham", 2, 3, 1),
                new Item("whiskey", 8, 13, 1)
            };

            int capacity = 10;

            ItemCollection[] ic = new ItemCollection[capacity + 1];

            FindOptimalSolution(items, capacity, ic);

            Console.WriteLine("Knapsack Capacity: " + capacity + "\n\nFilled Weight: " + ic[capacity].TotalWeight + "\n\nFilled Value: " + ic[capacity].TotalValue + "\n\nContents:");
            //TODO don't use string concatenation in a cycle
            foreach (KeyValuePair<string, int> kvp in ic[capacity].Contents) Console.WriteLine(kvp.Key + " (" + kvp.Value + ")");
        }

        private static void FindOptimalSolution(List<Item> items, int capacity, ItemCollection[] ic)
        {
            for (int i = 0; i <= capacity; i++)
            {
                ic[i] = new ItemCollection();
            }

            for (int i = 0; i < items.Count; i++)
            {
                for (int j = capacity; j >= 0; j--)
                {
                    if (j >= items[i].Weight)
                    {
                        int quantity = Math.Min(items[i].Quantity, j / items[i].Weight);
                        for (int k = 1; k <= quantity; k++)
                        {
                            ItemCollection lighterCollection = ic[j - k * items[i].Weight];
                            int testValue = lighterCollection.TotalValue + k * items[i].Value;
                            if (testValue > ic[j].TotalValue) (ic[j] = lighterCollection.Copy()).AddItem(items[i], k);
                        }
                    }
                } 
            }   
        }
    }
}