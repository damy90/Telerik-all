using System;
//Write methods that calculate the surface of a triangle by given:
//-Side and an altitude to it
//-Three sides
//-Two sides and an angle between them.

//to check the results against wolframalpha click the links above the methods.
class Program
{
    static void Main()
    {
        double side = 2;
        double heigth = 3;
        Console.WriteLine("Calculated by side and altitude to it: {0}", SideAndHeigth(side, heigth));

        double a = 2;
        double b = 4;
        double c = 5;
        Console.WriteLine("Calculated by 3 sides: {0}", ThreeSides(a, b, c));

        double side1=6;
        double side2=5;
        double angle=60;//angle is in degrees
        Console.WriteLine("Calculated by 2 sides and an angle between them: {0}", TwoSidesAndAngle(side1, side2, angle));
    }
    //side and heigth
    //http://www.wolframalpha.com/input/?i=A+%3D+1%2F4+sqrt%28%28a%2Bb-c%29+%28a-b%2Bc%29+%28-a%2Bb%2Bc%29+%28a%2Bb%2Bc%29%29+where+a%3D2%2C+b%3D4%2C+c%3D5
    private static double SideAndHeigth(double side, double heigth)
    {
        double area = side * heigth / 2;
        return area;
    }
    //Three sides
    //http://www.wolframalpha.com/widgets/view.jsp?id=d4dd111a4fd973394238aca5c05bebe3
    private static double ThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }
    //Two sides and an angle
    //http://www.wolframalpha.com/input/?i=a*b*sin%28c%29%2F2+for+a%3D5%2Cb%3D6%2C+c%3D60deg
    private static double TwoSidesAndAngle(double side1, double side2, double angle)
    {
        //the angle is converted to radians
        double area = (side1 * side2 * Math.Sin(angle * Math.PI / 180))/2;
        return area;
    }
}