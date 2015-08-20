using System;

//Write a static class with a static method to calculate the distance between two points in the 3D space.

public static class CalculateDistance3D
{
    public static double Calculate(Point3D point1, Point3D point2)
    {
        var result = Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2) + Math.Pow(point1.Z - point2.Z, 2));
        return result;
    }
}
