
namespace StringBuilder_Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extentions
    {
        /* Problem 1:
         * mplement an extension method Substring(int index, int length) 
         * for the class StringBuilder that returns new StringBuilder and 
         * has the same functionality as Substring in the class String. */

        public static StringBuilder SubString(this StringBuilder input, int start, int lenght)
        {
            var result = new StringBuilder();

            for (int i = start; i < lenght; i++)
            {
                result.Append(input[i]);
            }
            return result;
        }

        public static T Sum<T>(this IEnumerable<T> input)
        {
            dynamic result = 0;

            foreach (var item in input)
            {
                result += item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> input)
        {
            dynamic result = 0;

            foreach (var item in input)
            {
                result *= item;
            }

            return result;
        }

        public static T Mx<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic result = 0;

            foreach (var item in input)
            {
                if (item.CompareTo(result) > 0)
                {
                    result = item;
                }

            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic result = 0;

            foreach (var item in input)
            {
                if (item.CompareTo(result) < 0)
                {
                    result = item;
                }

            }
            return result;
        }
        public static T Average<T>(this IEnumerable<T> input) where T : IComparable
        {
            return (dynamic)input.Sum() / input.Count();
        }

    }
}
