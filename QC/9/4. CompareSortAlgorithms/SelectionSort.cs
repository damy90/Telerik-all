using System;
using System.Diagnostics;

namespace _4.CompareSortAlgorithms
{
    public static class SelectionSort
    {
        private static Stopwatch sw = new Stopwatch();

        public static int[] Integer(int[] arr)
        {
            var result = GenericCopier<int[]>.DeepCopy(arr);
            //pos_min is short for position of min

            sw.Restart();
            int pos_min, temp;

            for (int i = 0; i < result.Length - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[pos_min])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = result[i];
                    result[i] = result[pos_min];
                    result[pos_min] = temp;
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            return result;
        }

        public static double[] Double(double[] arr)
        {
            var result = GenericCopier<double[]>.DeepCopy(arr);
            //pos_min is short for position of min

            sw.Restart();
            int pos_min;
            double temp;

            for (int i = 0; i < result.Length - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[pos_min])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = result[i];
                    result[i] = result[pos_min];
                    result[pos_min] = temp;
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            return result;
        }

        public static string[] String(string[] arr)
        {
            var result = GenericCopier<string[]>.DeepCopy(arr);
            //pos_min is short for position of min

            sw.Restart();
            int pos_min;
            string temp;

            for (int i = 0; i < result.Length - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (string.Compare(result[j], result[pos_min]) < 0)
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = result[i];
                    result[i] = result[pos_min];
                    result[pos_min] = temp;
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            return result;
        }
    }
}
