using System;
//Write a method that counts how many times given number appears in given array.
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, -5, 9, 3, 8, 8, 1 };
        int number = 3;//value to be counted

        Console.WriteLine("The number {0} appears {1} times", number, CountNumber(number, numbers));
    }
    static int CountNumber(int number, int[] numbers)
    {
        int count=0;
        foreach (int i in numbers)
            if (i == number)
                count++;
        return count;
    }
}
