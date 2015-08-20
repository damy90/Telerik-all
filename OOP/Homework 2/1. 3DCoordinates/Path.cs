using System;
using System.Collections.Generic;
using System.Linq;

//4.Create a class Path to hold a sequence of points in the 3D space.

[Serializable()]
public class Path
{
    private readonly List<Point3D> path3D = new List<Point3D>();

    public Path(params Point3D points)
    {
        this.path3D = points.ToList();
    }

    public Path()
    {
        
    }
    public List<Point3D> Path3D
    {
        get
        {
            return this.path3D;
        }
    }

    public void AddPoint(Point3D point)
    {
        this.Path3D.Add(point);
    }
}
