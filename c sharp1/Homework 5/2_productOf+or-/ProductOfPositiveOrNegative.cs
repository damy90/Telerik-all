using System;

class ProductOfPositiveOrNegative
{
    //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    //*Use a sequence of if operators.
    static void Main()
    {
        Console.Title = "See if the product of three numbers is positive or negative";

        Console.Write("Please enter 1-st number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter 2-nd number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter 3-th number: ");
        int number3 = int.Parse(Console.ReadLine());

        if (number1 == 0 || number2 == 0 || number3 == 0)
            Console.WriteLine("The product is zero");
        else if (((number1 > 0) == (number2 > 0)) == (number3 > 0)) //example: -2*-3*8 => (false==false)==true is true => product is positive
            Console.WriteLine("The product is positive (+)");
        else
            Console.WriteLine("The product is negative (-)");
    }
}
