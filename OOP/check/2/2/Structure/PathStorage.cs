namespace Point
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public static class PathStorage
    {
        public static List<Path> LoadPath(string filePath)
        {
            StreamReader reader = new StreamReader("" + filePath + "");
            List<Path> ListOfPathsFromText = new List<Path>();
            string input = "Start";
            using (reader)
            {
                while (input != string.Empty)
                {
                    input = reader.ReadLine();
                    Path newPathFromText = new Path();
                    while (input != "End of Path" && input != "Start" && input != null)
                    {
                        Point3D currentPoint = new Point3D();
                        double[] pointCoord = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                        Select(double.Parse).ToArray();
                        currentPoint.PointX = pointCoord[0];
                        currentPoint.PointY = pointCoord[1];
                        currentPoint.PointZ = pointCoord[2];
                        newPathFromText.ListOfPoints.Add(currentPoint);
                        input = reader.ReadLine();
                    }
                    if (input == null)
                    {
                        break;
                    }
                    ListOfPathsFromText.Add(newPathFromText);
                }
                return ListOfPathsFromText;
            }
        }

        public static void SavePath(string filePath, List<Path> ListOfPaths)
        {
            StreamWriter writer = new StreamWriter(@"..\..\paths.txt");
            using (writer)
            {
                for (int i = 0; i < ListOfPaths.Count; i++)
                {
                    for (int j = 0; j < ListOfPaths[i].ListOfPoints.Count; j++)
                    {
                        writer.WriteLine("{0} {1} {2}", ListOfPaths[i].ListOfPoints[j].PointX, ListOfPaths[i].ListOfPoints[j].PointY, ListOfPaths[i].ListOfPoints[j].PointZ);

                        if (j == ListOfPaths[i].ListOfPoints.Count - 1)
                        {
                            writer.WriteLine("End of Path");
                        }
                    }
                }
            }
        }
    }
}

