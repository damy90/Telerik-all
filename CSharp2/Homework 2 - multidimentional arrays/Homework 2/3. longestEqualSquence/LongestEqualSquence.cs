using System;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

class LongestEqualSquence
{
    static void Main()
    {
        //horysontal check
        /*string[,] matrix={
                             {"as","gs","bg","es"},
                             {"ss","ss","ss","ss"},
                             {"gd","ff","fg","gg"}
        };*/
        //vertical check
        /*string[,] matrix ={
                             {"ss","gs","bg"},
                             {"ss","ss","ss"},
                             {"ss","kj","ss"},
                             {"ss","ff","fg"}
        };*/
        //dyagonal down check
        /*string[,] matrix ={
                             {"ss","gs","bg"},
                             {"ss","ss","d"},
                             {"ju","kj","ss"}
        };*/
        //dyagonal up check
        string[,] matrix ={
                             {"d","gs","ss"},
                             {"fg","ss","d"},
                             {"ss","kj","bf"}
        };
        //values by which row and column are incremented (4 directions, widhout top/left variants which have been processed)
        int[,] directions = { {1,-1}, {1,0}, {1,1}, {0,1} };
        int countMax = 0;
        string valueMax="";

        for (int col = 0; col < matrix.GetLength(1); col++)
            //optimization : if the largest sequence counted so far is larger than both the width and heigth of the remaining elements the rest of the elements are not checked
            for (int row = 0; row < matrix.GetLength(0) && (countMax < Math.Max(matrix.GetLength(0), matrix.GetLength(1))); row++)
                for (int variant = 0; variant < directions.GetLength(0); variant++) //count equal elements in all 4 directions
                {
                    int count = SequenceCount(matrix, row, col, directions[variant, 1], directions[variant, 0]);
                    if( count>countMax )
                    {
                        countMax = count;
                        valueMax = matrix[row,col];
                    }
                }
        //print the results
        Console.Write("The longest sequence is: ");
        for (int i = 0; i < countMax; i++)
            Console.Write("{0} ", valueMax);
        Console.WriteLine();
    }

    //count equal elements in one direction
    static int SequenceCount(string[,] matrix, int row, int col, int incrementRow, int incrementCol)//int startRow, int startCol, int incrementRow, int incrementCol)
    {
        string firstValue = matrix[row,col];
        int count = 0;
        do{
            //move onto the next element:
            row += incrementRow;
            col += incrementCol;
            count++;
            if( row >= matrix.GetLength(0) || row < 0 || col >= matrix.GetLength(1) )
                break;//outside the matrix, we don't check col<0 because col is always incremented
        }
        while( matrix[row,col]==firstValue );//continue while the value is the same
        return count;
    }
}
