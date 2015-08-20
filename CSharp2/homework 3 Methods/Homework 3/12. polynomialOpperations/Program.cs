using System;
//Extend the program (11) to support also subtraction and multiplication of polynomials.
class Program
{
    static void Main()
    {
        int[] polynomial1 = {1, 4 };
        int[] polynomial2 = { 1, 4, 1 };

        Subtract(polynomial1, polynomial2);
        Multiply(polynomial1, polynomial2);
        if (polynomial2.Length > polynomial1.Length)
        {
            Add(polynomial2, polynomial1);
        }
        else
        {
            Add(polynomial1, polynomial2);
        }
        
    }
    static void Add(int[] polynomial1, int[] polynomial2)
    {
        for (int i = 1; i <= polynomial2.Length; i++)
            polynomial1[polynomial1.Length - i] += polynomial2[polynomial2.Length - i];
        PrintResult(polynomial1);
    }

    
    static void Subtract(int[] polynomial1, int[] polynomial2)
    {
        int len = Math.Max(polynomial1.Length, polynomial2.Length);
        int[] result=new int[len];
        for (int i = 1; i <= len; i++)
        {
            int n1 = polynomial1.Length - i;
            int n2 = polynomial2.Length - i;
            int p1 = n1<0 ? 0: polynomial1[n1];//0 if n1 is negative
            int p2 = n2<0 ? 0: polynomial2[n2];
            result[len-i] = p1-p2;
        }
        PrintResult(result);
    }
    
    static void Multiply(int[] polynomial1, int[] polynomial2)
    {
        int len = polynomial1.Length + polynomial2.Length-1;
        int[] result = new int[len];
        for (int pos1 = 0; pos1 < polynomial1.Length; pos1++)
            for (int pos2 = 0; pos2 < polynomial2.Length; pos2++)
                result[pos1 + pos2] += polynomial1[pos1] * polynomial2[pos2];
        PrintResult(result);
    }
    //print all elements of the result
    private static void PrintResult(int[] result)
    {
        bool zeroResult = true;
        for (int i = 0; i < result.Length; i++)
        {
            //the degree of each term coresponds to its position in the array
            if (result[i] != 0)
            {
                Console.Write("{2}{0}x^{1} ", result[i], result.Length - i - 1, (result[i] > 0 && i>0) ? "+" : "");
                zeroResult = false;
            }
        }
        Console.WriteLine("{0}", zeroResult == true? "0":"");
    }
}