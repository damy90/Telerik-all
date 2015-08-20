namespace Point3D.Tests
{
    using System;
    using Path;
    public class PointTest
    {
        static void Main()
        {
            
            var point = new Point(2.3, 1, 0);
            var secPoint = new Point(1, 2, 5);
            var thirdPoint = new Point(3, 2, 2);

            Console.WriteLine(point.ToString());
            Console.WriteLine(Point.O);

            Console.WriteLine(DistanceBnTwoPoints.CalcDistTwoPoints(point, Point.O));

            var path = new Path();
            path.AddPointsPath(point);
            path.AddPointsPath(Point.O);
            path.AddPointsPath(secPoint);
            path.AddPointsPath(thirdPoint);

            PathStorage.SavePath(path);
            var pathLoad = PathStorage.LoadPath();

            foreach (var p in pathLoad.Points)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(new string('-', 59));

        }
    }
}
