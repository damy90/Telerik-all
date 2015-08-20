namespace Path
{
    using Point3D;
    using System;
    using System.IO;
    using System.Text;
    //Problem 4. Path
    //Create a class Path to hold a sequence of points in the 3D space.
    //Create a static class PathStorage with static methods to save and load paths from a text file.
    //Use a file format of your choice.

    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            StreamWriter sw = new StreamWriter("..\\..\\Path.txt");
            using (sw)
            {
                foreach (var p in path.Points)
                {
                    sw.WriteLine(p.ToString());
                }

            }
        }
        public static Path LoadPath()
        {
            StreamReader sr = new StreamReader("..\\..\\Path.txt");
            //StringBuilder sb = new StringBuilder();
            Path path = new Path();
            using (sr)
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    //sb.Append(line);
                    //sb.Append("\n");
                    var point = Point.Parse(line);
                    path.AddPointsPath(point);


                    line = sr.ReadLine();
                }

            }
            return path;
        }
    }
}
