using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        //Number to be converted (input number).
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        int toBase = 256;//kaspichan numeral system base

        Console.WriteLine(ToBase(number, toBase));
    }
    //convert int to kaspichan numeral system
    static string ToBase(BigInteger number, int toBase)
    {
        string result = "";
        do
        {
            int remainder = (int)(number % toBase);
            char smallLeter = (char)('a' + remainder / 26 - 1);
            char capitalLeter = (char)('A' + remainder % 26);

            result = capitalLeter.ToString() + result;//add the capital letter from the didgit
            //add the small letter if any
            if (smallLeter >= 'a')
                result = smallLeter.ToString() + result;

            number /= toBase;
        }
        while (number > 0);
        return result;
    }
}
