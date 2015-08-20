using System;
using System.Diagnostics;

namespace _4.CompareSortAlgorithms
{
    public static class InsertionSortGeneric<T> where T : IComparable
    {
        private static Stopwatch sw = new Stopwatch();

        public static T[] Sort(T[] inputarray)
        {
            var result = GenericCopier<T[]>.DeepCopy(inputarray);

            sw.Restart();
            for (int i = 0; i < result.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (result[j - 1].CompareTo(result[j]) > 0)
                    {
                        T temp = result[j - 1];
                        result[j - 1] = result[j];
                        result[j] = temp;
                    }

                    j--;
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            return inputarray;
        }
    }
}
