using System;
using System.Linq;

//Write a program that finds the sequence of maximal sum in given array. Example:
	//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	//Can you do it with only one loop (with single scan through the elements of the array)?
class ArraySequenceMaxSum
{
    static void Main()
    {
        int[] array;
        Console.WriteLine("Please enter aray values (comma sepparated)");
        char[] separators = { ',', ' ' };
        array = Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        //hardcoded test
        //array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int sum=array[0];
        string elementsSum= Convert.ToString(array[0])+" ";
        string result="";
        int maxSum=int.MinValue;

        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
            elementsSum += Convert.ToString(array[i])+" ";
            //запазва максималната сума
            if (maxSum < sum)
            {
                maxSum = sum;
                result = elementsSum;
            }
            //Ако сумата стане отрицателно число се нулира и започва да се смята от следващия елемент
            if (sum < 0)
            {
                sum = 0;
                elementsSum = "";
            }
        }
        Console.WriteLine(result);
    }
}
