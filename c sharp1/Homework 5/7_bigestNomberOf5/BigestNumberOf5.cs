using System;

class BigestNumberOf5
{
    static void Main()
    {
        Console.Title = "Find the bigest out of 5 numbers";

        int max = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            int number;
            while (true)
            {
                Console.Write("Please enter number {0}: ",i+1);
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                else
                    Console.Write("Invalid input");
            }

            if (number > max)
                max = number;
        }

        Console.WriteLine("The bigest number is: {0}",max);
    }
}