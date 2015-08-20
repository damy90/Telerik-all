using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Point3D point1 = new Point3D(1, 2, 4);
        Point3D point2 = new Point3D(-1, -2, -4);
        //Check http://www.wolframalpha.com/input/?i=distance+between+point&a=*C.distance+between+point-_*Calculator.dflt-&f2=%7B1%2C+2%2C+4%7D&f=DistanceCalculator.point1_%7B1%2C+2%2C+4%7D&f3=%7B-1%2C+-2%2C+-4%7D&f=DistanceCalculator.point2_%7B-1%2C+-2%2C+-4%7D&a=*FVarOpt.1-_***DistanceCalculator.point1-.*DistanceCalculator.point2--.***DistanceCalculator.point13D-.*DistanceCalculator.point23D---.*--
        Console.WriteLine(CalculateDistance3D.Calculate(point1, point2));
        Path path = new Path(point1, point2);
        path.AddPoint(Point3D.Origin);
        PathStorage.SavePath(path);
        Path path2 = PathStorage.ReadPath();
        Console.WriteLine(path2.Path3D[2]);
    }
}
