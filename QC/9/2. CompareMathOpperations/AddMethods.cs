using System;
using System.Diagnostics;
using System.Linq;

namespace _2.CompareMathOpperations
{
    class AddTests
    {
        private static readonly Stopwatch sw = new Stopwatch();

        public static void Int(int opperationsCount, int startValue=1)
        {
            sw.Restart();
            for (int i = 1, result= startValue; i < opperationsCount; i++)
            {
                result+=i;
            }
            sw.Stop();
            Console.WriteLine("Integer addition: {0}", sw.Elapsed);
        }
        public static void Long(long opperationsCount, long startValue=1)
        {
            sw.Restart();
            for (long i = 1, result = startValue; i < opperationsCount; i++)
            {
                result += i;
            }
            sw.Stop();
            Console.WriteLine("long addition: {0}", sw.Elapsed);
        }
        public static void Float(float opperationsCount, float startValue=1)
        {
            sw.Restart();
            for (float i = 1, result = startValue; i < opperationsCount; i++)
            {
                result += i;
            }
            sw.Stop();
            Console.WriteLine("float addition: {0}", sw.Elapsed);
        }
        public static void Double(double opperationsCount, double startValue=1)
        {
            sw.Restart();
            for (double i = 1, result = startValue; i < opperationsCount; i++)
            {
                result += i;
            }
            sw.Stop();
            Console.WriteLine("double addition: {0}", sw.Elapsed);
        }
        public static void Decimal(decimal opperationsCount, decimal startValue=1)
        {
            sw.Restart();
            for (decimal i = 1, result = startValue; i < opperationsCount; i++)
            {
                result += i;
            }
            sw.Stop();
            Console.WriteLine("decimal addition: {0}", sw.Elapsed);
        }
    }
}
