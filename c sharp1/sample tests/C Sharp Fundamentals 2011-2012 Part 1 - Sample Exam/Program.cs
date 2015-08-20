using System;

class Program
{
    static void Main()
    {
        //int x = int.Parse(Console.ReadLine());  //това забива когато въведеш дробно число
        //int y = int.Parse(Console.ReadLine());
        int x;
        int y;
        try
        {
            x = int.Parse(Console.ReadLine());  //това забива когато въведеш дробно число
            y = int.Parse(Console.ReadLine());
        }
        catch
        {
            throw new ApplicationException();
        }
        if (x > 0)
        {
            if (y > 0)
                Console.WriteLine("1");
            else if (y < 0)
                Console.WriteLine("4");
            else
                Console.WriteLine("6");
        }
        else if (x < 0)
        {
            if (y > 0)
                Console.WriteLine("2");
            else if (y < 0)
                Console.WriteLine("3");
        }
        else if (x == 0 && y == 0)
            Console.WriteLine("0");
        else
            Console.WriteLine("5");
    }
}
