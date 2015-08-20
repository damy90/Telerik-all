using System;


    class Program
    {
        static void Main()
        {
            double test=1;
            for(int i=1;i<=100;i++)
                test=checked(test*i);
        }
        Console.Write(test);
    }
