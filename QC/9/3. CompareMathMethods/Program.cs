using System;
using System.Linq;

namespace CompareMathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqrtTests.Double(2d, 10000d, 0.002d);
            SqrtTests.Decimal(2m, 10000m, 0.002m);
            SqrtTests.Float(2f, 10000f, 0.002f);
            Console.WriteLine();

            LogTests.Double(2d, 10000d, 0.002d);
            LogTests.Decimal(2m, 10000m, 0.002m);
            LogTests.Float(2f, 10000f, 0.002f);
            Console.WriteLine();

            SinusTests.Double(2d, 10000d, 0.002d);
            SinusTests.Decimal(2m, 10000m, 0.002m);
            SinusTests.Float(2f, 10000f, 0.002f);
        }
    }
}
