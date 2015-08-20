using System;
using System.Collections.Generic;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
class Program
{
    static void Main()
    {
        int[] array = { 2, 4, 1, 3, 5, 6, 9, 7, 8 };
        Sort(array);
    }
    //Returns the index of the greatest value in a range
    static int MaxInRange(int[] array, int index)
    {
        int max=int.MinValue;
        int maxIndex=-1;
        for (int i = index; i < array.Length; i++)
            if (max < array[i])
            {
                max = array[i];
                maxIndex = i;
            }
        return maxIndex;
    }

    static void Sort(int[] array)
    {
        //Sort assending: The Largest element in a range is switched with the last element in the range. Then the range is decreased.
        for (int index = 0; index < array.Length; index++)
        {
            int maxPos = MaxInRange(array, index);
            int temp = array[maxPos];
            array[maxPos] = array[index];
            array[index] = temp;
        }

        Console.WriteLine(string.Join(", ", array));
        //sort desending (reverse sorted array)
        Array.Reverse(array);
        Console.WriteLine(string.Join(", ", array));
    }
}
