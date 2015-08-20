using System;
using System.Linq;

//Write a program that finds the maximal increasing sequence in an array.
class MaxIncreasingSequence
{
    static void Main()
    {
        int[] array;
        Console.WriteLine("Please enter aray values (comma sepparated)");
        char[] separators = { ',', ' ' };
        array = Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        //hardcoded test
        //array = new int[] { 3, 2, 3, 4, 2, 2, 4 };
        int countMax = 1;
        int firstElementIndex = 0;
        for (int i = 0, count = 1; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1]-1)
                count++;
            else
                count = 1;
            if (count > countMax)
            {
                countMax = count;
                firstElementIndex = i+2-count;
            }
        }


        Console.Write("The longest increasing sequence is: ");
        for (int i = 0; i < countMax; i++)
            Console.Write("{0} ", array[firstElementIndex + i]);
        Console.WriteLine();
    }
}
