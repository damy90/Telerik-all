using System;


class Program
{
    static void Main()
    {
        Console.Title = "Check if a point is inside circle & outside rectagle";
        float x, y;
        Console.WriteLine("Please enter x coordinate");
        float.TryParse(Console.ReadLine(), out x);
        Console.WriteLine("Please enter y coordinate");
        float.TryParse(Console.ReadLine(), out y);

        float circleRadius = 3, circleX = 1, circleY = 1;
        float rectTop = 1, rectLeft = -1, rectBottom = -1, rectRight = 5;

        bool insideRect = x > rectLeft && x < rectRight && y < rectTop && y > rectBottom;

        float xCenterDist = circleX-x;
        float yCenterDist = circleY-y;
        float dist = (float)(Math.Sqrt(xCenterDist * xCenterDist + yCenterDist * yCenterDist));
        bool insideCircle = dist < circleRadius;

        Console.WriteLine("The piont {0} the circle and {1} the rectangle({2})", insideCircle ? "inside" : "outside", insideRect ? "inside" : "outside", (insideCircle && !insideRect));
    }
}
