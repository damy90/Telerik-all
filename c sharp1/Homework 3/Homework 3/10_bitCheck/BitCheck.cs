//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class BitCheck
{
    static void Main()
    {
        Console.Title = "Check if bit=0";
        int position;
        int number;
        Console.Write("Check if a bit at a given position is 1\nPlease enter a number: ");
        int.TryParse(Console.ReadLine(), out number);
        Console.Write("Please enter position of the bit: ");
        int.TryParse(Console.ReadLine(), out position);
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine(bit==1);
    }
}
