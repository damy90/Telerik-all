using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddOrEven
{
    static void Main()
    {
        int evenNumb = 1;
        int oddNumb = 1;

        string inputNumbs = Console.ReadLine();
        string[] numbers = inputNumbs.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                evenNumb *= number;
            }
            else
            {
                oddNumb *= number;
            }
        }

        if (evenNumb == oddNumb)
        {
            Console.WriteLine("Yes!");
            Console.WriteLine("Product = " + evenNumb);
        }
        else
        {
            Console.WriteLine("No!");
            Console.WriteLine("Odd product = " + oddNumb);
            Console.WriteLine("Even product = " + evenNumb);
        }
    }
}
