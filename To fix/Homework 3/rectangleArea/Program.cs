using System;

class Program
{
    static void Main()
    {
        int height;
        int width;
        Console.Title = "Rectangle area";
        Console.Write("Please enter height: ");
        while (true)//endles cycle (repeated untill break)
        {
            if (int.TryParse(Console.ReadLine(), out height)&&(height > 0))//Parses input for integer values and returns true or false
            {
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a positive integer number");
            }
         }
         Console.Write("Please enter width: ");
         while (true)//endles cycle (repeated untill break)
        {
            if (int.TryParse(Console.ReadLine(), out width)&&(width > 0))//Parses input for integer values and returns true or false
            {
                Console.WriteLine("\nThe area is {0}: ", width * height);
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a positive integer number");
            }
        }
    }
}