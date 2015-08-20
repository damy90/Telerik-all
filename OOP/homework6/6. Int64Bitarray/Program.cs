using System;

class Program
{
    static void Main()
    {
        Int64BitArray bits = new Int64BitArray(672);
        Console.WriteLine(bits);

        Int64BitArray newBits = bits;
        Console.WriteLine("Comparison works: {0}", bits == newBits);
        Console.WriteLine("The array is empty: {0}", bits == null);
        int position = 5;
        Console.WriteLine("Bit at position {0} is: {1}", position, bits[position]);
        //exeption test
        //Console.WriteLine(bits[64]);
    }
}
