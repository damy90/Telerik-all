//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class SwitchBits1
{
    static void Main()
    {
        Console.Title = "Switch bits 3, 4 and 5 with 24,25 and 25 ";
        Console.Write("Please enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("The number in binary:\t{0}",Convert.ToString(number, 2).PadLeft(32, '0'));

        uint mask1 = 7 << 3;//mask=111
        uint mask2 = 7 << 24;
        uint clearMask = ~(mask1 | mask2);

        uint result = (number & clearMask) | ((number & mask1) << 21) | ((number & mask2) >> 21);
        Console.WriteLine("The result in binary:\t{0}\nThe result:\t{1}",Convert.ToString(result, 2).PadLeft(32, '0'), result);
    }
}
