using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsCount=0;
            do
            {
                Console.WriteLine("Please enter numbers count.");
                int.TryParse(Console.ReadLine(), out elementsCount);
            }
            while (elementsCount < 1);

            Console.WriteLine("Please enter numbers.");

            Stack<int> numbers = new Stack<int>();
            string input;
            int inputNumber;

            for (int i = 0; i < elementsCount; )
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out inputNumber))
                {
                    numbers.Push(inputNumber);
                    i++;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
