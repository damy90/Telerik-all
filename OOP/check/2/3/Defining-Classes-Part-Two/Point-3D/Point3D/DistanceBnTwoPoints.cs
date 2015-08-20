namespace Point3D
{
    using System;
    
    public static class DistanceBnTwoPoints
    {
        public static double CalcDistTwoPoints(Point firstPoint, Point secPoint)
        {
            double distance = 0;

            distance = Math.Sqrt((firstPoint.X - secPoint.X) * (firstPoint.X - secPoint.X) +
                                 (firstPoint.Y - secPoint.Y) * (firstPoint.Y - secPoint.Y) +
                                 (firstPoint.Z - secPoint.Z) * (firstPoint.Z - secPoint.Z));

            return distance;
        }
    }
     
}
