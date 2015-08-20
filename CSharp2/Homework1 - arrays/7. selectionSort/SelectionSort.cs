using System;
using System.Linq;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
class SelectionSort
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

        int indexMin;

        for (int indexFirstUnsorted = 0; indexFirstUnsorted < array.Length - 1; indexFirstUnsorted++)
        {
            indexMin = indexFirstUnsorted;
            for (int i = indexFirstUnsorted + 1; i < array.Length; i++)
            {
                if (array[indexMin] > array[i])
                    indexMin = i;
            }
            if (indexMin != indexFirstUnsorted)
            {
                int k = array[indexFirstUnsorted];
                array[indexFirstUnsorted] = array[indexMin];
                array[indexMin] = k;
            }
        }

        Console.WriteLine(string.Join(", ", array));
    }
}