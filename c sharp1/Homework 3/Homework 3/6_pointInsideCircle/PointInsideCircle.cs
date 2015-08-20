//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

using System;

class PointInsideCircle
{
    static void Main()
    {
        int x, y;
        int radius = 2;
        Console.Title = "Is the point within the circle with radius 5?";
        Console.Write("Please enter x coordinate: ");
        int.TryParse(Console.ReadLine(), out x);
        Console.Write("Please enter y coordinate: ");
        int.TryParse(Console.ReadLine(), out y);
        decimal distanceFromCenter=(decimal)Math.Pow((x*x+y*y),0.5);
        
        Console.WriteLine("The point is {0} the circle", (distanceFromCenter < radius) ? "within" : "outside");
    }
}
