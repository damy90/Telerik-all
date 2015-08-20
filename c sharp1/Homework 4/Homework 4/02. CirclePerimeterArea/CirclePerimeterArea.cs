using System;

class CirclePerimeterArea
{
    //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
    static void Main()
    {
        float radius;

        Console.Title = "Circle perimeter and area";
        Console.Write("Please enter radius: ");
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out radius) && radius>0)
                break;
            else
                Console.WriteLine("Please enter a positive number");
        }

        float perimeter = (float)(2 * radius * Math.PI);
        float area = (float)(radius * radius * Math.PI);
        Console.WriteLine("The perimeter is: {0}\nThe area is: {1}", perimeter.ToString("0.00"), area.ToString("0.00"));
    }
}
