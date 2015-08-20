using System;
//* Modify your last program and try to make it work for any number type, not just integer. Use generic method
class Program
{
    static void Main()
    {
        Console.WriteLine("The average for (1, 1, 3, 3) is: {0}", Average<double>(1.5, 1, 3.8, 3));
        Console.WriteLine("The sum for (1, -1, 3, -3, 0) is: {0}", Sum<int>(1, -1, 3, -3, 1));
        Console.WriteLine("The Minimum value for (1, 3, -3, -2) is: {0}", Min<long>(1, 3, -3, -2));
        Console.WriteLine("The Maximum value for (1, 3, -3, -2) is: {0}", Max<sbyte>(1, 3, -3, -2));
        Console.WriteLine("The product for (1, 3, -3, -2) is: {0}", Product(1, 3, -3, -2));
    }

    static T Sum<T>(params T[] array)
    {
        //The type dynamic is a static type, but an object of type dynamic bypasses static type checking.
        //In most cases, it functions like it has type object.
        //At compile time, an element that is typed as dynamic is assumed to support any operation.
        dynamic sum = 0;
        foreach( dynamic number in array)
            sum += number;
        return sum;
    }

    static T Average<T>(params T[] array)
    {
        dynamic sum = Sum(array);
        return (sum / array.Length);
    }

    static T Min<T>(params T[] array)
    {
        dynamic min = array[0];
        for (int i = 1; i < array.Length; i++)
            if (min > array[i])
                min = array[i];
        return min;
    }

    static T Max<T>(params T[] array)
    {
        dynamic max = array[0];
        for (int i = 1; i < array.Length; i++)
            if (max < array[i])
                max = array[i];
        return max;
    }

    static T Product<T>(params T[] array)
    {
        dynamic product = 1;
        foreach (dynamic number in array)
            product *= number;
        return product;
    }
}
