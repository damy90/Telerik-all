using System;

namespace _2.CombinationsWithDuplicates
{
    class Program
    {
        private static readonly int[] result = new int[K];
        private const int N = 4;
        private const int K = 2;

        public static void Main()
        {
            Combinations(1);
        }


        private static void Combinations(int startValue, int depth = 0)
        {
            if (depth >= K)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            for (int i = startValue; i < N; i++)
            {
                result[depth] = i;
                Combinations(i, depth + 1);
            }
        }
    }
}
