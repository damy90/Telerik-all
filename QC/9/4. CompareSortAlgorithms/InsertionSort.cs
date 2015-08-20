using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace _4.CompareSortAlgorithms
{
    public static class InsertionSort
    {
        private static Stopwatch sw = new Stopwatch();

        public static int[] Int(int[] inputarray)
        {
            var result = GenericCopier<int[]>.DeepCopy(inputarray);

            sw.Restart();
            for (int i = 0; i < result.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (result[j - 1] > result[j])
                    {
                        int temp = result[j - 1];
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

        public static double[] Double(double[] inputarray)
        {
            var result = GenericCopier<double[]>.DeepCopy(inputarray);

            sw.Restart();
            for (int i = 0; i < result.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (result[j - 1] > result[j])
                    {
                        double temp = result[j - 1];
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

        public static string[] String(string[] inputarray)
        {
            var result = GenericCopier<string[]>.DeepCopy(inputarray);

            sw.Restart();
            for (int i = 0; i < result.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (string.Compare(result[j - 1], result[j]) > 0)
                    {
                        string temp = result[j - 1];
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

        public static IList Sort(IList inputarray)
        {
            var result = GenericCopier<IComparable[]>.DeepCopy(inputarray);

            sw.Restart();
            for (int i = 0; i < result.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (result[j - 1].CompareTo(result[j]) > 0)
                    {
                        var temp = result[j - 1];
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
