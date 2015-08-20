using System;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
class QuickSortArray
{
    public static void Main()
    {
        string[] items = { "add", "fyyx", "aarx", "xgrhcr", "ssztp", "trd j", "dfvz" };
        int i;

        Console.WriteLine("Original array: ");
        for (i = 0; i < items.Length; i++)
            Console.WriteLine(items[i]);
 
        Quicksort(items, 0, items.Length - 1);

        Console.WriteLine("Sorted array: ");
        for (i = 0; i < items.Length; i++)
            Console.WriteLine(items[i]);
    }
 
    static void Quicksort(string[] items, int left, int right)
    {
        int l, r;
        string pivot, y;

        l = left; r = right;
        pivot = items[(left + right) / 2];

        do
        {
            while ((items[l].CompareTo(pivot)<0) && (l < right)) l++;
            while ((pivot.CompareTo(items[r])<0) && (r > left)) r--;

            if (l <= r)
            {
                y = items[l];
                items[l] = items[r];
                items[r] = y;
                l++; r--;
            }
        } while (l <= r);

        if (left < r) Quicksort(items, left, r);
        if (l < right) Quicksort(items, l, right);
    }
}