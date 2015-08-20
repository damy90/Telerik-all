//check results for circles: http://www.wolframalpha.com/input/?i=circle+area+d%3D3
using System;

class Program
{
    static void Main()
    {
        Shape[] shapes = 
        {
            new Triangle(2,2),
            new Rectangle(2,3),
            new Circle(3),//diameter
            new Square(2),
            //invalid input test
            //new Rectangle(-2,-2)
        };

        foreach (var shape in shapes)
            Console.WriteLine(shape.CaslculateSurface());
    }
}