using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompareSortAlgorithms
{
    class Program
    {
        private static Random random = new Random();
        private static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            Console.Write("Press enter to start!");
            Console.ReadLine();

            int length = random.Next(1, 100);
            int[] randomInts = new int[length];
            for (int i = 0; i < length; i++)
            {
                randomInts[i] = random.Next(int.MinValue, int.MaxValue);
            }

            int[] sortedInt = GenericCopier<int[]>.DeepCopy(randomInts);
            Array.Sort(sortedInt);
            int[] reversedSortInt = GenericCopier<int[]>.DeepCopy(sortedInt);
            Array.Reverse(reversedSortInt);

            double[] randomDoubles = new double[length];
            for (int i = 0; i < length; i++)
            {
                randomDoubles[i] = random.Next(short.MinValue, short.MaxValue) + random.NextDouble();
            }

            double[] sortedDouble = GenericCopier<double[]>.DeepCopy(randomDoubles);
            Array.Sort(sortedDouble);
            double[] reversedDouble = GenericCopier<double[]>.DeepCopy(sortedDouble);
            Array.Reverse(reversedDouble);

            string[] randomStrings = new string[length];
            for (int i = 0; i < length; i++)
            {
                randomStrings[i] = RandomString();
            }

            string[] sortedString = GenericCopier<string[]>.DeepCopy(randomStrings);
            Array.Sort(sortedString);
            string[] reverseSortedString = GenericCopier<string[]>.DeepCopy(sortedString);
            Array.Reverse(reverseSortedString);

            Console.WriteLine("Insertion sort ");
            Console.Write("int random: \t\t");
            InsertionSort.Int(randomInts);

            Console.Write("int sorted: \t\t");
            InsertionSort.Int(sortedInt);


            Console.Write("int sorted reversed: \t");
            InsertionSort.Int(reversedSortInt);

            Console.Write("double random: \t\t");
            InsertionSort.Double(randomDoubles);

            Console.Write("double sorted: \t\t");
            InsertionSort.Double(sortedDouble);

            Console.Write("double sorted reversed:\t");
            InsertionSort.Double(reversedDouble);

            Console.Write("string random: \t\t");
            InsertionSort.String(randomStrings);

            Console.Write("string sorted: \t\t");
            InsertionSort.String(sortedString);

            Console.Write("string sorted reversed:\t");
            InsertionSort.String(reverseSortedString);

            Console.WriteLine("\nInsertion sort generic method");

            Console.Write("int random: \t\t");
            InsertionSortGeneric<int>.Sort(randomInts);

            Console.Write("int sorted: \t\t");
            InsertionSortGeneric<int>.Sort(sortedInt);

            Console.Write("int sorted reversed: \t");
            InsertionSortGeneric<int>.Sort(reversedSortInt);

            Console.Write("double random: \t\t");
            InsertionSortGeneric<double>.Sort(randomDoubles);

            Console.Write("double sorted: \t\t");
            InsertionSortGeneric<double>.Sort(sortedDouble);

            Console.Write("double sorted reversed:\t");
            InsertionSortGeneric<double>.Sort(reversedDouble);

            Console.Write("string random: \t\t");
            InsertionSortGeneric<string>.Sort(randomStrings);

            Console.Write("string sorted: \t\t");
            InsertionSortGeneric<string>.Sort(sortedString);

            Console.Write("string sorted reversed:\t");
            InsertionSortGeneric<string>.Sort(reverseSortedString);

            Console.WriteLine("\nSelection sort ");

            Console.Write("int random: \t\t");
            SelectionSort.Integer(randomInts);

            Console.Write("int sorted: \t\t");
            SelectionSort.Integer(sortedInt);

            Console.Write("int sorted reversed: \t");
            SelectionSort.Integer(reversedSortInt);

            Console.Write("double random: \t\t");
            SelectionSort.Double(randomDoubles);

            Console.Write("double sorted: \t\t");
            SelectionSort.Double(sortedDouble);

            Console.Write("double sorted reversed:\t");
            SelectionSort.Double(reversedDouble);

            Console.Write("string random: \t\t");
            SelectionSort.String(randomStrings);

            Console.Write("string sorted: \t\t");
            SelectionSort.String(sortedString);

            Console.Write("string sorted reversed:\t");
            SelectionSort.String(reverseSortedString);

            Console.WriteLine("\nQuicksort sort ");

            //tested differentli because the method has recursion. 
            //First call of a method is always much slower.
            Quicksort.Int(new int[] { 1 }, 0, 0);
            Quicksort.Double(new double[] { 1 }, 0, 0);
            Quicksort.String(new string[] { "a" }, 0, 0);

            sw.Restart();
            Quicksort.Int(randomInts, 0, length - 1);
            sw.Stop();
            Console.WriteLine("int random: \t\t" + sw.Elapsed);

            sw.Restart();
            Quicksort.Int(sortedInt, 0, length - 1);
            sw.Stop();
            Console.WriteLine("int sorted: \t\t" + sw.Elapsed);

            sw.Restart();
            Quicksort.Int(reversedSortInt, 0, length - 1);
            sw.Stop();
            Console.WriteLine("int sorted reversed: \t" + sw.Elapsed);

            sw.Restart();
            Quicksort.Double(randomDoubles, 0, length - 1);
            sw.Stop();
            Console.WriteLine("double random: \t\t" + sw.Elapsed);

            sw.Restart();
            Quicksort.Double(sortedDouble, 0, length - 1);
            sw.Stop();
            Console.WriteLine("double sorted: \t\t" + sw.Elapsed);

            sw.Restart();
            Quicksort.Double(reversedDouble, 0, length - 1);
            sw.Stop();
            Console.WriteLine("double sorted reversed:\t" + sw.Elapsed);

            sw.Restart();
            Quicksort.String(randomStrings, 0, length - 1);
            sw.Stop();
            Console.WriteLine("string random: \t\t" + sw.Elapsed);

            sw.Restart();
            Quicksort.String(sortedString, 0, length - 1);
            sw.Stop();
            Console.WriteLine("string sorted: \t\t" + sw.Elapsed);

            sw.Restart();
            Quicksort.String(reverseSortedString, 0, length - 1);
            sw.Stop();
            Console.WriteLine("string sorted reversed:\t" + sw.Elapsed);
        }

        private static string RandomString()
        {
            int length = random.Next(1, 100);
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append((char)('a' + random.Next(26)));
            }

            return result.ToString();
        }
    }
}
