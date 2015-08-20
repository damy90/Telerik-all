using System;

class Program
{
    static void Main()
    {
        uint B = uint.Parse(Console.ReadLine());
        uint N = uint.Parse(Console.ReadLine());
        uint[] number = new uint[N];
        
        for (uint i = 0; i < N; i++)
            number[i] = uint.Parse(Console.ReadLine());

        for (uint i = 0; i < N && B==1; i++)
        {
            uint count=0;
            for (uint mask = 1; number[i] > 0; number[i] =(number[i]>>1))
                if ((number[i] & mask) == 1)
                    count++;
            Console.WriteLine(count);
        }
        for (uint i = 0; i < N && B == 0; i++)
        {
            uint count = 0;
            for (uint mask = 1; number[i] > 0; number[i] = (number[i] >> 1))
                if ((~number[i] & mask) == 1)
                    count++;
            Console.WriteLine(count);
        }
    }
}
