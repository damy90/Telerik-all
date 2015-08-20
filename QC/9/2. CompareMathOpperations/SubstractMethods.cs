using System;
using System.Diagnostics;
using System.Linq;

namespace _2.CompareMathOpperations
{
    class SubstractTests
    {
        private static readonly Stopwatch sw = new Stopwatch();

        public static void Int(int opperationsCount, int startValue = 10000)
        {
            sw.Restart();
            for (int i = 1, result = startValue; i > opperationsCount; i++)
            {
                result -= i;
            }
            sw.Stop();
            Console.WriteLine("Integer subtract: {0}", sw.Elapsed);
        }
        public static void Long(long opperationsCount, long startValue = 10000)
        {
            sw.Restart();
            for (long i = 1, result = startValue; i > opperationsCount; i++)
            {
                result -= i;
            }
            sw.Stop();
            Console.WriteLine("long subtract: {0}", sw.Elapsed);
        }
        public static void Float(float opperationsCount, float startValue = 10000)
        {
            sw.Restart();
            for (float i = 1, result = startValue; i > opperationsCount; i++)
            {
                result -= i;
            }
            sw.Stop();
            Console.WriteLine("float subtract: {0}", sw.Elapsed);
        }
        public static void Double(double opperationsCount, double startValue = 10000)
        {
            sw.Restart();
            for (double i = 1, result = startValue; i > opperationsCount; i++)
            {
                result -= i;
            }
            sw.Stop();

            Console.WriteLine("double subtract: {0}", sw.Elapsed);
        }
        public static void Decimal(decimal opperationsCount, decimal startValue = 10000)
        {
            sw.Restart();
            for (decimal i = 1, result = startValue; i > opperationsCount; i++)
            {
                result -= i;
            }
            sw.Stop();

            Console.WriteLine("decimal subtract: {0}", sw.Elapsed);
        }
    }
}
