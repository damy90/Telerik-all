using System;

class SumOfXNumbers
{
    static void Main()
    {
        Console.Title = "Sum n numbers";
        int numberCount;
        float number, sum=0;

        Console.WriteLine("How many numbers would you like to add?");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numberCount)&& numberCount>=1)
                break;
            else
                Console.WriteLine("Please enter a positive integer number");
        }

        for (int i = 1; i <= numberCount; i++)
        {
            while (true)
            {
                Console.Write("Please enter number {0}:",i);
                if (float.TryParse(Console.ReadLine(), out number))
                    break;
                else
                    Console.WriteLine("Please enter a number");
            }
            sum = sum + number;
        }

        Console.WriteLine("The sum is: {0}",sum);
    }
}
