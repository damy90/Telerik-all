using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Permutations
{
    class Program
    {
        private static readonly int[] permutations = new int[N];
        private static readonly bool[] used = new bool[N];
        private const int N = 3;
        private static int combinationsCount = 0;

        public static void Main()
        {
            getPermutations();
            Console.WriteLine(combinationsCount);
        }

        private static void getPermutations(int depth = 0)
        {
            if (depth >= N)
            {
                Console.WriteLine(string.Join(" ", permutations));
                combinationsCount++;
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if (used[i])
                {
                    continue;
                }

                used[i] = true;
                permutations[depth] = i+1;
                getPermutations(depth + 1);
                used[i] = false;
            }
        }
    }
}
