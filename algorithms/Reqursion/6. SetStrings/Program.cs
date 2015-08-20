using System;

namespace _6.SetStrings
{
    class Program
    {
        private static readonly string[] elements = { "test", "rock", "fun" };
        private static readonly string[] combination = new string[elements.GetLength(0)];
        private const int K = 2;

        public static void Main()
        {
            Combinations(0);
        }

        private static void Combinations(int index, int depth = 0)
        {
            if (depth >= K)
            {
                Console.WriteLine(string.Join(" ", combination));
                return;
            }

            for (int i = index; i < elements.GetLength(0); i++, index++)
            {
                combination[depth] = elements[i];
                Combinations(index + 1, depth + 1);
            }
        }
    }
}
