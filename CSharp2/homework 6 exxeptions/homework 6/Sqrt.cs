using System;
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye".
class Sqrt
{
    static void Main()
    {
        try
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
