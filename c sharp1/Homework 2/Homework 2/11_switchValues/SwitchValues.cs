//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.

using System;

class SwitchValues
{
    static void Main(string[] args)
    {
        int var1 = 5;
        int var2 = 10;
        int buffer = var1;
        var1 = var2;
        var2 = buffer;
        Console.WriteLine("Variable 1={0} \nVariable 2={1}",var1,var2);
    }
}
