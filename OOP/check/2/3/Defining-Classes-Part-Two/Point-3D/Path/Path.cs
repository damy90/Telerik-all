namespace Path
{
    using System;
    using System.Collections.Generic;
    using Point3D;

    //Problem 4. Path
    //Create a class Path to hold a sequence of points in the 3D space.
    //Create a static class PathStorage with static methods to save and load paths from a text file.
    //Use a file format of your choice.

    public class Path
    {
        private List<Point> points;

        public Path()
        {
            Points = new List<Point>();
        }
        public List<Point> Points
        {
            get
            {
                return this.points;
            }
            private set
            {
                this.points = value;
            }
        }

        public void AddPointsPath(Point point)
        {
            Points.Add(point);
        }

    }
  
}
