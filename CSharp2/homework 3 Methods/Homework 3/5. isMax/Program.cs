using System;
//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, -5, 9, 3, 8, 8, 1 };
        int position = 1;
        Console.Write("The value ta position {0} is greater than its neighbours: ", position);
        IsMax(numbers, position);
    }

    static void IsMax(int[] numbers, int position)
    {
        if (position > 0 && position < numbers.Length - 1)
            Console.WriteLine(numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1]);

        else
            Console.WriteLine("Posiion out of range");
    }
}
