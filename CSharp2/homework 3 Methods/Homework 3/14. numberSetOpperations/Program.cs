using System;
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
class Program
{
    static void Main()
    {
        Console.WriteLine("The average for (1, 1, 3, 3) is: {0}", Average(1, 1, 3, 3));
        Console.WriteLine("The sum for (1, -1, 3, -3, 0) is: {0}", Sum(1, -1, 3, -3, 0));
        Console.WriteLine("The Minimum value for (1, 3, -3, -2) is: {0}", Min(1, 3, -3, -2));
        Console.WriteLine("The Maximum value for (1, 3, -3, -2) is: {0}", Max(1, 3, -3, -2));
        Console.WriteLine("The product for (1, 3, -3, -2) is: {0}", Product(1, 3, -3, -2));
    }
    static int Sum(params int[] array)
    {
        int sum = 0;
        foreach (int number in array)
            sum += number;
        return sum;
    }

    static int Average(params int[] array)
    {
        int sum = Sum(array);
        return (sum / array.Length);
    }

    static int Min(params int[] array)
    {
        int min = int.MaxValue;
        foreach (int number in array)
            if (min > number)
                min = number;
        return min;
    }
    static int Max(params int[] array)
    {
        int max = int.MinValue;
        foreach (int number in array)
            if (max < number)
                max = number;
        return max;
    }
    static int Product(params int[] array)
    {
        int product = 1;
        foreach (int number in array)
            product *= number;
        return product;
    }
}
