using System;
//Write a program to convert binary numbers to hexadecimal numbers (directly).
class Program
{
    static void Main()
    {
        int[] binary = { 1, 0, 1, 1, 0, 0 };
        char[] hexMap = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        string result="";
        
        for (int i = binary.Length-1; i >=0 ; )
        {
            int hexIndex = 0;
            int j = i;
            //for every 4 bits the hexadecimal value is calculated
            for (; (j > i - 4)&&(j>=0); j--)
                hexIndex +=binary[j] * (1 << (i - j));

            result = hexMap[hexIndex] + result;
            i=j;
        }
        Console.WriteLine(result);
    }
}
