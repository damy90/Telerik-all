using System;

//Write a program that compares two char arrays lexicographically (letter by letter).
class CompareCharArray
{
    static void Main()
    {
        Console.Write("Please enter array size: ");
        int N = int.Parse(Console.ReadLine());
        char[] array1 = new char[N];
        char[] array2 = new char[N];

        Console.WriteLine("Please enter values for the 1-st array as a string");
        for (int i = 0; i < N; i++)
            array1[i] = Console.ReadKey().KeyChar;
        Console.WriteLine("\nPlease enter values for the 2-nd array");
        for (int i = 0; i < N; i++)
        {
            array2[i] = Console.ReadKey().KeyChar;
            Console.WriteLine("\nThe elements {0} from the two arrays are {1} equal", i, array1[i] == array2[i] ? "" : "not");
        }
    }
}
