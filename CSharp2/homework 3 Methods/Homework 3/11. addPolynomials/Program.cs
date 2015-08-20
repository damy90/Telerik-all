using System;
//Write a method that adds two polynomials. Represent them as arrays of their coefficients.
class Program
{
    static void Main()
    {
        int[] polynomial1 = { 5, 0, 1 };
        int[] polynomial2 = { 3, 10, 0, 2, 4 };
        //values will be added to the array with more values
        if (polynomial2.Length > polynomial1.Length)
            Add(polynomial2, polynomial1);
        else
            Add(polynomial1, polynomial2);
    }
    //add elements of the polynomial based to their power (starts from 0 to n)
    static void Add(int[] polynomial1, int[] polynomial2)
    {
        for (int i = 1; i <= polynomial2.Length; i++)
            polynomial1[polynomial1.Length - i] += polynomial2[polynomial2.Length - i];
        
        PrintResult(polynomial1);
    }
    //print all elements of the result
    private static void PrintResult(int[] result)
    {
        bool zeroResult = true;
        for (int i = 0; i < result.Length; i++)
        {
            //if an element is 0 it is not printed
            if (result[i] != 0)
            {
                //+ is NOT added to the first element and to negative elements
                Console.Write("{2}{0}x^{1} ", result[i], result.Length - i - 1, (result[i] > 0 && i > 0) ? "+" : "");
                zeroResult = false;
            }
        }
        Console.WriteLine("{0}", zeroResult == true ? "0" : "");//print 0 if all elements are 0
    }
}
