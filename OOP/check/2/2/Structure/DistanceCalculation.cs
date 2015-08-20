namespace Point
{
    using System;
    public static class DistanceCalculation
    {
        public static double Distance(Point3D a, Point3D b)
        {
            double distance=0;
            distance=Math.Sqrt(Math.Pow(b.PointX-a.PointX,2)+
                Math.Pow(b.PointY-a.PointY,2)+
                Math.Pow(b.PointZ-a.PointZ,2));
            return distance;
        }
    }
}
