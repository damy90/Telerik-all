namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //Problem 1. Structure
    //Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    //Implement the ToString() to enable printing a 3D point.

    public struct Point
    {
        //    Problem 2. Static read-only field
        //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        //Add a static property to return the point O.

        private static readonly Point o = new Point() { X = 0, Y = 0, Z = 0 };
        //private double x;
        //private double y;
        //private double z;
        //constructor

        public static Point O 
        {
            get
            {
                return o;
            }
        }

        public Point(double x, double y, double z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X {get;set;}
        //{
        //    get
        //    {
        //        return this.x;
        //    }
        //    set
        //    {
        //        this.x = value;
        //    }
        //}
        public double Y {get;set;}
        //{
        //    get
        //    {
        //        return this.y;
        //    }
        //    set
        //    {
        //        this.y = value;
        //    }
        //}
        public double Z { get; set; }
        //{
        //    get
        //    {
        //        return this.z;
        //    }
        //    set
        //    {
        //        this.z = value;
        //    }
        //}

        


        public override string ToString()
        {

            return string.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }
        public static Point Parse(string text)
        {
            //2, 1, 0
            string[] idxs = text.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            double x = double.Parse(idxs[0]);
            double y = double.Parse(idxs[1]);
            double z = double.Parse(idxs[2]);
            var p = new Point(){X=x,Y=y,Z=z};
            return p;
        }
    }
}
