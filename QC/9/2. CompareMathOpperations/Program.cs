using System;
using System.Linq;

namespace _2.CompareMathOpperations
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTests.Decimal(500000m);
            AddTests.Double(500000d);
            AddTests.Float(500000f);
            AddTests.Int(500000);
            AddTests.Long(500000L);
            Console.WriteLine();

            SubstractTests.Decimal(500000m);
            SubstractTests.Double(500000d);
            SubstractTests.Float(500000f);
            SubstractTests.Int(500000);
            SubstractTests.Long(500000L);
            Console.WriteLine();

            MultiplyTests.Decimal(2m, 500000m, 2m);
            MultiplyTests.Double(2d, 500000d, 5d);
            MultiplyTests.Float(2f, 500000f, 5f);
            MultiplyTests.Int(2, 500000, 5);
            MultiplyTests.Long(2L, 500000L, 5L);
            Console.WriteLine();

            DivideTests.Decimal(500000m, 4m, 2m);
            DivideTests.Double(500000d, 4d, 2d);
            DivideTests.Float(500000f, 4f, 2f);
            DivideTests.Int(500000, 4, 2);
            DivideTests.Long(500000L, 4L, 2L);
        }
    }
}
