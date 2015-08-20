using System;

class Program
{
    static void Main()
    {
        int height;
        int base1;
        int base2;
        Console.Title = "Trapezoid area";
        Console.Write("Please enter height: ");
        while (true)//endles cycle (repeated untill break)
        {
            if (int.TryParse(Console.ReadLine(), out height) && (height > 0))//Parses input for integer values and returns true or false
            {
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a positive integer number");
            }
        }
        Console.Write("Please enter size of the first base: ");
        while (true)//endles cycle (repeated untill break)
        {
            if (int.TryParse(Console.ReadLine(), out base1) && (base1 > 0))//Parses input for integer values and returns true or false
            {
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a positive integer number");
            }
        }
        Console.Write("Please enter size of the second base: ");
        while (true)//endles cycle (repeated untill break)
        {
            if (int.TryParse(Console.ReadLine(), out base2) && (base2 > 0))//Parses input for integer values and returns true or false
            {
                Console.WriteLine("\nThe area is {0}: ", (base1+base2) * height/2);
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a positive integer number");
            }
        }
    }
}
