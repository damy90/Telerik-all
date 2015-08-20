using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("The number in binary:\t{0}",Convert.ToString(number, 2).PadLeft(32, '0'));

        uint mask1 = 7 << 3;//mask=111
        uint mask2 = 7 << 24;
        uint clearMask = ~(mask1 | mask2);

        uint result = (number & clearMask) | ((number & mask1) << 21) | ((number & mask2) >> 21);
        Console.WriteLine("The result:\t{0}\nThe result in binary{1}",result, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
