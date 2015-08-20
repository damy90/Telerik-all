//Write a program to print the numbers 1, 101 and 1001, each at a separate line.

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine(1);
        Console.WriteLine(101);
        Console.WriteLine(1001);
        Console.WriteLine(); // this code make new line in console

        short firstNumber = 1;
        short secondNumber = 101;
        short thirdNumber = 1001;
        Console.WriteLine("{0}\n{1}\n{2}", firstNumber, secondNumber, thirdNumber);
    }
}

