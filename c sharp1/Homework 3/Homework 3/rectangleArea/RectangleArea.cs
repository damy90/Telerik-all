//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;

class RectangleArea
{
    static void Main()
    {
        int height;
        int width;
        Console.Title = "Rectangle area";
        Console.Write("Please enter height: ");
        //endles cycle (repeated untill valid input)
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out height) && (height > 0))//Input validation. Parses input for integer values and returns true or false
            {
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a positive integer number");
            }
        }
        Console.Write("Please enter width: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out width) && (width > 0))
            {
                Console.WriteLine("\nThe area is: {0}\nThe perimeter is: {1}", width * height, 2 * (width + height));
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter a positive integer number");
            }
        }
    }
}