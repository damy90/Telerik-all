using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//$y = 2; //k!
//$n = 1;
//$k = 1;
//for ($i = 2, $j = 2; $i <= $x, $j <= $y; $i++, $j++){
// $n *= $i;
// $k *= $j;
class CalculateNdivideK
{
    static void Main()
    {
        Console.Write("Enter a number for 'n': ");
        long numbN = long.Parse(Console.ReadLine());

        Console.Write("Enter a number for 'k': ");
        long numbK = long.Parse(Console.ReadLine());
        Console.WriteLine();

        //Calculate factorial for "N"
        long tempValueN = 1;
        for (int i = 2; i <= numbN; i++)
        {
            tempValueN *= i;
        }
        Console.WriteLine("Factorial from 'n' is: {0}", tempValueN);

        //Calculate factorial for "K"
        long tempValueK = 1;
        for (int j = 2; j <= numbK; j++)
        {
            tempValueK *= j;
        }
        Console.WriteLine("Factorial from 'k' is: {0}", tempValueK);
        Console.WriteLine();

        //Calculate the result - N!/K!
        long result = tempValueN / tempValueK;
        Console.WriteLine("N!/K! - the result is: {0}", result);

    }
}

