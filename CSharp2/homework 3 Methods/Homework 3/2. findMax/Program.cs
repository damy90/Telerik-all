using System;
//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
class Program
{
    static void Main()
    {
        int[] numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = int.Parse(Console.ReadLine());

        int max = GetMax(numbers[2], (GetMax(numbers[0], numbers[1])));
        Console.WriteLine("The max is: {0}", max);
    }

    static int GetMax(int number1, int number2)
    {
        return Math.Max(number1, number2);
    }
}