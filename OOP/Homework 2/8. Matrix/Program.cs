using System;

class Program
{
    static void Main()
    {
        double[,] matrix ={
                         {1, 2.4},
                         {4.6, 22}
                         };

        Matrix<double> theStickReinvented = new Matrix<double>(matrix);
        Console.WriteLine(theStickReinvented[1, 0]);

        theStickReinvented[1, 0] = 3;
        Console.WriteLine(theStickReinvented[1, 0]);

        theStickReinvented = theStickReinvented + theStickReinvented;
        Console.WriteLine(theStickReinvented[0, 1]);

        Console.WriteLine("The matrix contains 0 elements {0}", theStickReinvented ? false : true);

        double[,] matrix2 ={
                         {0, 2.4}
                         };

        var theStickReinvented2 = new Matrix<double>(matrix2);
        Console.WriteLine("The matrix contains 0 elements {0}", theStickReinvented2 ? false : true);

        //exception test
        //theStickReinvented = theStickReinvented * theStickReinvented2;
    }
}
