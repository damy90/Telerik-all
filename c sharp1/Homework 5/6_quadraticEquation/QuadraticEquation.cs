using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Find the rooths of a quadratic equation";
        double a, b, c, discriminant, result1, result2;
        Console.Write("Please enter a value for a: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out a))
                break;
            else
                Console.WriteLine("Please enter a number");
        }
        Console.Write("Please enter a value for b: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out b))
                break;
            else
                Console.WriteLine("Please enter a number");
        }
        Console.Write("Please enter a value for c: ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out c))
                break;
            else
                Console.WriteLine("Please enter a number");
        }

        if (a != 0)
        {
            discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                result1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                result2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1= {0}, x2= {1}", result1, result2);
            }
            else if (discriminant == 0)
                Console.WriteLine("x= {0}", -b / 2 * a);

            else
                Console.WriteLine("There are no real rooths");
        }
        else if (a == 0 && b == 0 && c == 0)
            Console.WriteLine("x= Every real number");
        else if (a == 0 && b != 0)
            Console.WriteLine("x= {0}", -c / b);
        else
            Console.WriteLine("There are no real rooths");
    }
}
