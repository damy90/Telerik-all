//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class Read3thBit
{
    static void Main()
    {
        Console.Title = "Read the 3-th didgit";
        int position = 3;
        int number;
        Console.Write("Please enter a number:\t");
        int.TryParse(Console.ReadLine(), out number);
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("The 3-th bit is {0}",bit);
    }
}
