using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RemooveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> TestData = new List<int>() { -4, 2, -2, 2, 5, 5, 2, -3, 2, 3, 1, 5, 2 };

            List<int> sequence = GetPositiveNumbers(TestData);

            Console.WriteLine(string.Join(", ", sequence));
        }

        private static List<int> GetPositiveNumbers(List<int> input)
        {
            List<int> positiveNumbers = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] >= 0)
                {
                    positiveNumbers.Add(input[i]);
                }
            }
            return positiveNumbers;
        }
    }
}
