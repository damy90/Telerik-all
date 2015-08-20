using System;

//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
class ArrayIndexOfEllement
{
    static void Main()
    {
        int[] array = { 0, 1, 2, 3, 5, 5, 6, 7, 8, 9, 10, 15 };
        Console.WriteLine("Please enter a number between 0 and 10");
        int searchedNumber = int.Parse(Console.ReadLine());
        int startSearch = 0;
        int endSearch = array.Length - 1;
        int middle;

        while (startSearch <= endSearch)
        {
            middle = (startSearch + endSearch) / 2;

            if (array[middle] == searchedNumber)
            {
                Console.WriteLine("Index is: {0}.", middle);
                return;
            }

            if (array[middle] < searchedNumber)
                startSearch = middle + 1;

            else if (array[middle] > searchedNumber)
                endSearch = middle - 1;
        }

        Console.WriteLine("There is no such number in the array");
    }
}
