using System;

class BigestNumber
{
    //Write a program that finds the biggest of three numbers.

    static void Main()
    {
        Console.Title = "Find the bigest number";

        Console.Write("Please enter 1-st number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter 2-nd number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter 3-th number: ");
        int number3 = int.Parse(Console.ReadLine());

        int bigest = number1;
        if (number1==number2&&number1==number3)
            Console.WriteLine("All numbers are equal");
        else if (number1 < number2)
        {
            if (number2 < number3)
                bigest = number3;
            else
                bigest = number2;
        }
        else
        {
            if (number1 < number3)
                bigest = number3;
            else
                bigest = number1;
        }

        Console.WriteLine("The bigest number is: {0}",bigest);
    }
}
