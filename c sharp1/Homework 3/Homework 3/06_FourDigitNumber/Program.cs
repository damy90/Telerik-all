//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//-Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//-Prints on the console the number in reversed order: dcba (in our example 1102).
//-Puts the last digit in the first position: dabc (in our example 1201).
//-Exchanges the second and the third digits: acbd (in our example 2101).

using System;

class Program
{
    static void Main()
    {
        int number;
        char[] didgits = new char[4];

        Console.WriteLine("Please enter a four didgit number");
        while (true)
        {
            //valid number check
            if (int.TryParse(Console.ReadLine(), out number) && number <= 9999 && number > 999)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a number between 999 and 10000");
            }
        }

        //results
        didgits = number.ToString().ToCharArray();
        int sum = 0;
        foreach (char didgit in didgits)
        {
            sum += int.Parse(didgit.ToString());
        }
        Console.WriteLine("The sum of all the didgits is: {0}", sum);

        Array.Reverse(didgits);
        Console.WriteLine("The didgits in reverse order: {0}", string.Join("", didgits));

        Array.Reverse(didgits);
        char[] rightShift = new char[didgits.Length];
        Array.Copy(didgits, 0, rightShift, 1, didgits.Length - 1);
        rightShift[0] = didgits[3];
        Console.WriteLine(string.Join("", rightShift));

        char[] mixedDidgits = new char[didgits.Length];
        mixedDidgits[0] = didgits[0];
        mixedDidgits[1] = didgits[2];
        mixedDidgits[2] = didgits[1];
        mixedDidgits[3] = didgits[3];
        Console.WriteLine(string.Join("", mixedDidgits));
    }
}
