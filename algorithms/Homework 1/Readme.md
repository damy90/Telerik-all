# 1-ва задача:
Слопжността на алгоритъма е O(n^2) защото 1-вия масив обхожда n елемента, а вложения - n елемента за всяка итерация на 1-вия.
```C# 
long Compute(int[] arr)
{
    long count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        int start = 0, end = arr.Length-1;
        while (start < end)
            if (arr[start] < arr[end])
                { start++; count++; }
            else 
                end--;
    }
    return count;
}
```

# 2-ра задача:
Сложността е O(n*m) защото алгоритъма обхожда всичките n*m на брой елементи 
```C# 
long CalcCount(int[,] matrix)
{
    long count = 0;
    for (int row=0; row<matrix.GetLength(0); row++)
        if (matrix[row, 0] % 2 == 0)
            for (int col=0; col<matrix.GetLength(1); col++)
                if (matrix[row,col] > 0)
                    count++;
    return count;
}
```

# 3-та задача:
Сложността е O(n*m) защото обхожда всички редове рекурсивно и всички колони от съответния ред в цикъл. Така се обхождат всичките n*m на брой елемента
```C# 
long CalcSum(int[,] matrix, int row)
{
    long sum = 0;
    for (int col = 0; col < matrix.GetLength(0); col++) 
        sum += matrix[row, col];
    if (row + 1 < matrix.GetLength(1)) 
        sum += CalcSum(matrix, row + 1);
    return sum;
}

Console.WriteLine(CalcSum(matrix, 0));
```