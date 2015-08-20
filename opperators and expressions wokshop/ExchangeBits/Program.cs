using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        int mask1 = 7 << 3;
        int mask2 = 7 << 24;
        int clearMask = ~(mask1|mask2);

        int result = (number & clearMask) | ((number & mask1) << 21) | ((number & mask2) >> 21);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        //int mask = 1 << 3;
        //int thirdBit = (number & mask) >> 3;

        //mask = 1 << 24;
        //int twentyFourthBit = (number & mask) >> 24;

        //if (thirdBit == twentyFourthBit)
        //{
        //    Console.WriteLine(number);
        //    return;
        //}

        //if (thirdBit == 0)
        //{
        //    //put 0 in 24th position
        //    mask = ~(1 << 24);
        //    number = number & mask;
        //}
        //else if (thirdBit == 1)
        //{
        //    //put 1 in 24th position
        //    mask = 1 << 24;
        //    number = number | mask;
        //}

        //if (twentyFourthBit == 0)
        //{
        //    //put 0 in third position
        //    mask = ~(1 << 3);
        //    number = number & mask;
        //}
        //else if (twentyFourthBit == 1)
        //{
        //    //put 1 in third position
        //    mask = 1 << 3;
        //    number = number | mask;
        //}

        //Console.WriteLine(Convert.ToString(number,2).PadLeft(32, '0'));
    }
}
