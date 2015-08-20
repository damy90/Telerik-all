//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInCircleOutsideRectangle
{
    static void Main()
    {
        Console.Title = "Check if a point is inside circle & outside rectagle";
        float x, y;
        Console.Write("Please enter x coordinate:\t");
        float.TryParse(Console.ReadLine(), out x);
        Console.Write("Please enter y coordinate:\t");
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
