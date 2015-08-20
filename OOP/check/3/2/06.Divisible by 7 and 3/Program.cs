using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_by_7_and_3
{
    using System;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main()
        {
            var testArray = Enumerable.Range(1, 50).ToArray();
            Console.WriteLine("Numbers in the test array:\n{0}", string.Join(", ", testArray));

            var divisible = testArray.Where(x => x % 3 == 0 && x % 7 == 0);
            Console.WriteLine("Numbers, divisible by 3 and 7 (using lambda):\n{0}", string.Join(", ", divisible));

            var divisible2 =
                from number in testArray
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine("Numbers, divisible by 3 and 7 (using LINQ):\n{0}", string.Join(", ", divisible2));
        }
    }
}
