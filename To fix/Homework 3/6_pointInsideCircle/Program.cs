using System;

class Program
{
    static void Main()
    {
        int x, y;
        int radius = 5;
        Console.WriteLine("Please enter x coordinate");
        int.TryParse(Console.ReadLine(), out x);
        Console.WriteLine("Please enter y coordinate");
        int.TryParse(Console.ReadLine(), out y);
        decimal distanceFromCenter=(decimal)Math.Pow((x*x+y*y),0.5);
        
        Console.WriteLine("The point is {0} the circle", (distanceFromCenter < radius) ? "within" : "outside");
    }
}
