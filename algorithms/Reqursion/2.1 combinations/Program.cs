using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_combinations
{
    class Program
    {
        private static readonly int[] result = new int[K];
        private const int N = 3;
        private const int K = 2;

        public static void Main()
        {
            Combinations(1);
        }


        private static void Combinations(int startValue, int depth=0)
        {
            if (depth >= K)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            for (int i = startValue; i <= N; i++)
            {
                result[depth] = i;
                Combinations(i, depth + 1);
            }
        }
    }
}
