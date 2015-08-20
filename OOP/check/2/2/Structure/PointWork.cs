

//Problem 1. Structure
//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//Problem 2. Static read-only field
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.

//Problem 3. Static class
//Write a static class with a static method to calculate the distance between two points in the 3D space.

//Problem 4. Path
//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.




namespace Point
{
    using System;
    using System.Collections.Generic;       
    public class PointWork
    {
        public static void createPoint()
        {
            Console.WriteLine("Examplary points");
            Point3D pointInput1 = new Point3D(-7, -4, 3);
            Point3D pointInput2 = new Point3D(17, 6, 2.5);
            Console.WriteLine("Point A:");
            Console.WriteLine(pointInput1);
            Console.WriteLine("Point B:");
            Console.WriteLine(pointInput2);
            double distance = DistanceCalculation.Distance(pointInput1, pointInput2);
            Console.WriteLine("The distance between point A and point B is:");
            Console.WriteLine(distance);
            string filePath = "../../Paths.txt";

            List<Path> ListOfPaths = new List<Path>();
            while (true)
            {
                Console.WriteLine("Do you want to create a new path:");
                string input = Console.ReadLine();
                if (input == "Yes")
                {
                    Path newPath = new Path();
                    newPath.ListOfPoints = newPath.AddPath();                    
                    ListOfPaths.Add(newPath);
                   
                    PathStorage.SavePath(filePath,ListOfPaths);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("The text files paths.txt is in the folder called \"Structure\".");
            //The paths from the text file are here:
            List<Path> ListOfRecordedPaths = PathStorage.LoadPath(filePath);         
        }
        public static void Main()
        {
            createPoint();
        }
    }   
}
