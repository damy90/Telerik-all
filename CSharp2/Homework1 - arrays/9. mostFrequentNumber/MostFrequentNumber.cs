using System;
using System.Linq;

//Write a program that finds the most frequent number in an array.
class MostFrequentNumber
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
        //array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int countMax = 0;
        int numberMostFrequent = 0;

        for (int number = 0; number < array.Length; number++)
        {
            int count = 0;
            for (int i = number; i < array.Length; i++)
                if (array[number] == array[i])
                    count++;
            if (countMax < count)
            {
                countMax = count;
                numberMostFrequent = array[number];
            }
        }
        Console.WriteLine("{0} ({1} times)", numberMostFrequent, countMax);
    }
}
