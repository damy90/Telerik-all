using System;
using System.Linq;

//Write a program that finds in given array of integers a sequence of given sum S (if present).
class FindSequenceSum
{
    static void Main()
    {
        int[] array;
        int checkSum;
        Console.WriteLine("Please enter aray values (comma sepparated)");
        char[] separators = { ',', ' ' };
        array = Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine("Please enter S");
        checkSum = int.Parse(Console.ReadLine());
        //hardcoded test
        //array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        //checkSum = 11;
        string result = "";

        for (int i = 0; i < array.Length; i++)
        {
            int sum = array[i];
            string elementsSum = Convert.ToString(array[i]);
            if (sum == checkSum)
            {
                result = elementsSum;
                break;
            }
            for (int j = i + 1; j < array.Length; j++)
            {
                sum += array[j];
                elementsSum +=", "+ Convert.ToString(array[j]);
                if (sum == checkSum)
                {
                    result = elementsSum;
                    break;
                }
            }
        }
        Console.WriteLine(result);
    }
}
