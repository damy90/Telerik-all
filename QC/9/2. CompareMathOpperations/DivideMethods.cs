using System;
using System.Diagnostics;
using System.Linq;

namespace _2.CompareMathOpperations
{
    class DivideTests
    {
        private static readonly Stopwatch sw = new Stopwatch();

        public static void Int(int startValue, int endValue, int step)
        {
            sw.Restart();
            for (int i = startValue; i >= endValue; )
            {
                i = i / step;
            }
            sw.Stop();
            Console.WriteLine("Integer division: {0}", sw.Elapsed);
        }
        public static void Long(long startValue, long endValue, long step)
        {
            sw.Restart();
            for (long i = startValue; i >= endValue; )
            {
                i = i / step;
            }
            sw.Stop();
            Console.WriteLine("long division: {0}", sw.Elapsed);
        }
        public static void Float(float startValue, float endValue, float step)
        {
            sw.Restart();
            for (float i = startValue; i >= endValue; )
            {
                i = i / step;
            }
            sw.Stop();
            Console.WriteLine("float division: {0}", sw.Elapsed);
        }
        public static void Double(double startValue, double endValue, double step)
        {
            sw.Restart();
            for (double i = startValue; i >= endValue; )
            {
                i = i / step;
            }
            sw.Stop();
            Console.WriteLine("double division: {0}", sw.Elapsed);
        }
        public static void Decimal(decimal startValue, decimal endValue, decimal step)
        {
            sw.Restart();
            for (decimal i = startValue; i >= endValue; )
            {
                i = i / step;
            }
            sw.Stop();
            Console.WriteLine("decimal division: {0}", sw.Elapsed);
        }
    }
}
