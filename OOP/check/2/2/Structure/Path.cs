namespace Point
{
    using System;
    using System.Collections.Generic;
   
    public class Path
    {
        private List<Point3D> listOfPoints;
        
        public Path()
        {
            this.ListOfPoints = new List<Point3D>();
        }

        public List<Point3D> ListOfPoints
        {
            get
            {
                return this.listOfPoints;
            }
            set
            {
                this.listOfPoints = value;
            }
        }
        public void AddPoint(Point3D newPoint)
        {
            this.listOfPoints.Add(newPoint);
        }
        public void RemovePoint(Point3D pointForRemoving)
        {
            this.listOfPoints.Remove(pointForRemoving);
        }

        public List<Point3D> AddPath()
        {
            Console.WriteLine("Enter the number of points which you want to add:");
            List<Point3D> ListOfPoints = new List<Point3D>();
            int number = int.Parse(Console.ReadLine());
            //Path newPath = new Path();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter X for the new point:");
                double newPointX = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y for the new point:");
                double newPointY = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Z for the new point:");
                double newPointZ = double.Parse(Console.ReadLine());
                Point3D newPoint = new Point3D(newPointX, newPointY, newPointZ);
                ListOfPoints.Add(newPoint);
            }
            return ListOfPoints;
        }        
    }
}
