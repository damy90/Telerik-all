using System;

class RandomNumbersInRange
{
    //Write a program that enters 3 integers n, 
    //min and max (min = max) and prints n 
    //random numbers in the range [min...max].
    static void Main(string[] args)
    {
        Console.Write("Enter count: ");
        int count = int.Parse(Console.ReadLine());

        if (count < 1)
        {
            Console.WriteLine("No numbers to show.");
            return;
        }

        Console.Write("Enter min of range: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max of range: ");
        int max = int.Parse(Console.ReadLine());

        int[] numbers = new int[count];
        Random random = new Random();
        for (int index = 0; index < count; index++)
        {
            numbers[index] = random.Next(min, max + 1);
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}