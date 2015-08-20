using System;
using System.Linq;

/* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)*/
class Program
{
    static void Main()
    {
        int[] array;
        int S;
        Console.WriteLine("Please enter aray values (comma sepparated)");
        char[] separators = { ',', ' ' };
        array = Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine("Please enter S");
        S = int.Parse(Console.ReadLine());

        //hardcoded test
        //array = new int[] {2, 1, 2, 4, 3, 5, 2, 6};
        //S = 14;
        
        string expression;
        bool subsetExists = false;

        for (int variants = 1; variants < (1 << array.Length); variants++)
        {
            expression = "";
            int sum = 0;
            for (int i = 0; (i < array.Length); i++)
            {
                if (((variants & (1 << i)) != 0))
                {
                    sum += array[i];
                    expression += "(" + array[i] + ")" + " +";
                }
            }
            if (sum == S)
            {
                expression = expression.Remove(expression.Length - 1);
                Console.WriteLine("{0}={1}", expression, S);
                subsetExists = true;
                break;
            }
        }
        if (!subsetExists)
            Console.WriteLine("The subset does not exist");
    }
}