using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.FindEvenOccuranceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var elementsToRemove = numbers.ToLookup(x => x).Where(xs => xs.Count() % 2 != 0);
            foreach (var item in elementsToRemove)
            {
                numbers.RemoveAll(x => x == item.Key);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
