using System;


//Write a program that reads two arrays from the console and compares them element by element.
class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter array size");
        int N = int.Parse(Console.ReadLine());
        string[] array1 = new string[N];
        string[] array2 = new string[N];

        Console.WriteLine("Please enter values for the 1-st");
        for (int i = 0; i < N; i++)
            array1[i] = Console.ReadLine();

        Console.WriteLine("Please enter values for the 2-nd");
        for (int i = 0; i < N; i++)
        {
            array2[i] = Console.ReadLine();
            Console.WriteLine("The elements {0} from the two arrays are {1} equal", i, array1[i] == array2[i]? "":"not");
        }
    }
}
