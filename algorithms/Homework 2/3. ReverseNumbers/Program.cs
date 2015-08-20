using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ReverseNumbers
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

            numbers.Sort();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
