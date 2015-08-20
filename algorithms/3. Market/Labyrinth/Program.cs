using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    class Program
    {
        static char[,] lab;
        static int countMax = 0;
        static int currentCount = 0;
        static List<Tuple<int, int>> path = new List<Tuple<int, int>>();

        static void Main(string[] args)
        {
            var startPosition = Console.ReadLine().Split(' ');
            var labSize = Console.ReadLine().Split(' ');
            lab = new char[int.Parse(labSize[0]), int.Parse(labSize[1])];

            for (int i = 0; i < lab.GetLength(0); i++)
            {
                var rowInput = string.Join("", Console.ReadLine().Split(' ')).ToCharArray();
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    lab[i, j] = rowInput[j];
                }
            }

            FindPathToExit(int.Parse(startPosition[0]), int.Parse(startPosition[1]));
            Console.WriteLine(countMax);
        }

        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }

        static void FindPathToExit(int row, int col)
        {

            if (!InRange(row, col))
            {
                // We are out of the labyrinth -> can't find a path
                //countMax = Math.Max(countMax, currentCount);
                //PrintPath(row, col);
                //currentCount = 0;
                return;
            }

            int power = 0;
            if (!int.TryParse(lab[row, col].ToString(), out power))
            {
                // The current cell is not free -> can't find a path
                countMax = Math.Max(countMax, currentCount);
                //currentCount = 0;
                //PrintPath(row, col);
                //Console.WriteLine(countMax);
                return;
            }

            currentCount += power;

            char cellValue = lab[row, col];
            // Temporary mark the current cell as visited to avoid cycles
            lab[row, col] = '#';
            path.Add(new Tuple<int, int>(row, col));

            // Invoke recursion the explore all possible directions
            if ((!InRange(row, col - power) || lab[row, col - power] == '#')
                && (!InRange(row - power, col) || lab[row - power, col] == '#')
                && (!InRange(row, col + power) || lab[row, col + power] == '#')
                && (!InRange(row + power, col) || lab[row + power, col] == '#'))
            {
                currentCount = 0;
                countMax = Math.Max(countMax, currentCount);
                PrintPath(row, col);
                Console.WriteLine(countMax);
                return;
            }

            FindPathToExit(row, col - power); // left
            FindPathToExit(row - power, col); // up
            FindPathToExit(row, col + power); // right
            FindPathToExit(row + power, col); // down

            // Mark back the current cell as free
            // Comment the below line to visit each cell at most once
            lab[row, col] = cellValue;
            path.RemoveAt(path.Count - 1);
        }

        private static void PrintPath(int finalRow, int finalCol)
        {
            Console.Write("path: ");
            foreach (var cell in path)
            {
                Console.Write("({0},{1}) -> ", cell.Item1, cell.Item2);
            }
            Console.WriteLine("({0},{1})", finalRow, finalCol);
            Console.WriteLine();
        }
    }
}
