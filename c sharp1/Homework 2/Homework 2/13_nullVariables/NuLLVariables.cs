//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NuLLVariables
{
    static void Main(string[] args)
    {
        int? null1 = null;
        double? null2 = null;
        string str = "";

        Console.WriteLine("Null int number={0}\nNull double+10={1}\nNull string={2}\nString+text={3}",
            null1, null2 + 10, str, str + "text");
        Console.WriteLine("Assigning some values");

        null1 = 2;
        str = "text2";
        Console.WriteLine("Null double afrer assigning a value of 2={0}\nNull string afrer assigning a value={1}", null2, str);
    }
}
