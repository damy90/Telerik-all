using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 1 and 100");
        string input;
        int n = 0;

        input = Console.ReadLine();
        if (!int.TryParse(input, out n))
        {
            throw new ArgumentException("Invalid number!");
        }

        var matrix = new WalkMatrix(n);
        Console.WriteLine(matrix.ToString());
    }
}