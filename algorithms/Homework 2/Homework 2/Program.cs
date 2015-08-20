using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers.");

            List<int> numbers = new List<int>();
            string input;
            int inputNumber;

            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out inputNumber))
                {
                    numbers.Add(inputNumber);
                }
            }
            while (!string.IsNullOrEmpty(input.Trim()));

            int sum=0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            int average = sum / numbers.Count;

            Console.WriteLine("The sum is: {0} \nThe average is: {1}", sum, average);
        }
    }
}
