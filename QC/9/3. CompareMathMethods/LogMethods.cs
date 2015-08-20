namespace CompareMathMethods
{
    using System;
    using System.Diagnostics;

    class LogTests
    {
        private static readonly Stopwatch sw = new Stopwatch();
        public static void Float(float startValue, float endValue, float step)
        {
            sw.Restart();
            for (float i = startValue; i <= endValue; i = i + step)
            {
                Math.Log(i);
            }

            sw.Stop();
            Console.WriteLine("float Math.Log: {0}", sw.Elapsed);
        }

        public static void Decimal(decimal startValue, decimal endValue, decimal step)
        {
            sw.Restart();
            for (decimal i = startValue; i <= endValue; i = i + step)
            {
                Math.Log((double)i);
            }

            sw.Stop();
            Console.WriteLine("decimal Math.Log: {0}", sw.Elapsed);
        }

        public static void Double(double startValue, double endValue, double step)
        {
            sw.Restart();
            for (double i = startValue; i <= endValue; i = i + step)
            {
                Math.Log(i);
            }

            sw.Stop();
            Console.WriteLine("double Math.Log: {0}", sw.Elapsed);
        }
    }
}
