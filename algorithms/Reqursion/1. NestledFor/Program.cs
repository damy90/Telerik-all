using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.NestledFor
{
    class Program
    {
        private static readonly int[] result = new int[N];
        private const int N = 2;

        public static void Main()
        {
            SimulateNestedLoops();
        }

        private static void SimulateNestedLoops(int depth = 0)
        {
            if (depth >= N)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                result[depth] = i;
                SimulateNestedLoops(depth + 1);
            }
        }
    }
}
