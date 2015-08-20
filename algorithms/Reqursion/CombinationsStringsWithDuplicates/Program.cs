using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsStringsWithDuplicates
{
    class Program
    {
        private static readonly string[] elements = { "hi", "a", "b" };
        private static readonly string[] combination = new string[elements.GetLength(0)];
        private const int K = 3;
        private static int combinationsCount = 0;

        public static void Main()
        {
            Combinations();
            Console.WriteLine(combinationsCount);
        }


        private static void Combinations(int depth = 0)
        {
            if (depth >= K)
            {
                Console.WriteLine(string.Join(" ", combination));
                combinationsCount++;
                return;
            }

            for (int i = 0; i < elements.GetLength(0); i++)
            {
                combination[depth] = elements[i];
                Combinations(depth + 1);
            }
        }
    }
}
