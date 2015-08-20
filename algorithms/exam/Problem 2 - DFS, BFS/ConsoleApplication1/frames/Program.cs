using System;
using System.Collections.Generic;
using System.Text;

namespace frames
{
    class Program
    {
        private static int[,] frames;
        private static int[,] combination;
        private static int framesCount;
        private static bool[] used;
        private static readonly SortedSet<string> combinations = new SortedSet<string>();

        public static void Main()
        {
            framesCount = int.Parse(Console.ReadLine());
            frames = new int[framesCount, 2];
            used = new bool[framesCount];
            combination = new int[framesCount, 2];

            for (int i = 0; i < framesCount; i++)
            {
                var frameStrings = Console.ReadLine().Split(' ');
                frames[i, 0] = int.Parse(frameStrings[0]);
                frames[i, 1] = int.Parse(frameStrings[1]);
            }

            Combinations();

            Console.WriteLine(combinations.Count);
            var result = new StringBuilder();
            foreach (var item in combinations)
            {
                result.AppendLine(item);
                //Console.WriteLine(item);
            }

            Console.WriteLine(result);
        }

        private static void Combinations(int depth = 0)
        {
            if (depth >= framesCount)
            {
                var combinationStrings=new List<string>();
                for (int i = 0; i < framesCount; i++ )
                   combinationStrings.Add(string.Format("({0}, {1})", combination[i, 0], combination[i, 1]));
                //foreach()
                var combinationString = string.Join(" | ", combinationStrings);
                combinations.Add(combinationString);
                return;
            }

            for (int i = 0; i < frames.GetLength(0); i++)
            {
                if (used[i])
                {
                    continue;
                }

                used[i] = true;
                combination[depth, 0] = frames[i,0];
                combination[depth, 1] = frames[i, 1];

                Combinations(depth + 1);

                Swap(ref combination[depth, 0], ref combination[depth, 1]);
                Combinations(depth + 1);
                Swap(ref combination[depth, 0], ref combination[depth, 1]);

                used[i] = false;
            }
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
