using System;
using System.Linq;

//Write a program that finds the maximal sequence of equal elements in an array.
class MaxSequenceEqualElements
{
    static void Main()
    {
        int[] array;
        Console.WriteLine("Please enter aray values (comma sepparated)");
        char[] separators={',', ' '};
        array = Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        
        int countMax = 1;
        int sequence = 0;
        //hardcoded test
        //array = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        for (int i = 0, count = 1; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
                count++;
            else
                count = 1;
            if (count > countMax)
            {
                countMax = count;
                sequence = array[i];
            }
        }

        Console.Write("The longest sequence is: ");
        for (int i = 0; i < countMax; i++)
            Console.Write("{0} ", sequence);
        Console.WriteLine();
    }
}
