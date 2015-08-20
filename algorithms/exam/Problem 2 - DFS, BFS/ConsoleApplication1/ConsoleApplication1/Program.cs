using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Position
    {
        public int Row;
        public int Col;
        public int Level;
        public int Depth;
        public Position(int level, int row, int col, int depth = 0)
        {
            this.Row = row;
            this.Col = col;
            this.Level = level;
            this.Depth = depth;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.Row.GetHashCode();
                result = result * 23 + this.Col.GetHashCode();
                result = result * 23 + this.Level.GetHashCode();
                return result;
            }
        }

        public static Position Parse(string s)
        {
            string[] coordinateStrings = s.Split(' ');

            return new Position(int.Parse(coordinateStrings[0]),
                int.Parse(coordinateStrings[1]),
                int.Parse(coordinateStrings[2])
                );
        }

        public override bool Equals(object obj)
        {
            try
            {
                Position objAsPosition = (Position)obj;
                return this.Level == objAsPosition.Level && this.Row == objAsPosition.Row && this.Col == objAsPosition.Col;
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }
    }

    class Program
    {
        static int levels;
        static int rows;
        static int cols;
        static void Main(string[] args)
        {
            var startPosition = Position.Parse(Console.ReadLine());
            var size = Position.Parse(Console.ReadLine());

            levels = size.Level;
            rows = size.Row;
            cols = size.Col;

            var cube = new char[levels, rows, cols];

            for (int l = 0; l < levels; l++)
            {
                for (int r = 0; r < rows; r++)
                {
                    var row = Console.ReadLine().ToCharArray();
                    for (int c = 0; c < cols; c++)
                    {
                        cube[l, r, c] = row[c];
                    }
                }
            }

            Console.WriteLine(GetShortestRoutDistanceBfs(cube, startPosition));
        }

        static int GetShortestRoutDistanceBfs(char[, ,] cube, Position startPosition)
        {
            Queue<Position> toVisit = new Queue<Position>();
            toVisit.Enqueue(startPosition);

            Position currentPosition;
            while (toVisit.Count > 0)
            {
                currentPosition = toVisit.Dequeue();
                //visited[currentPosition.Level, currentPosition.Row, currentPosition.Col] = true;

                var neighbours = GetNeighbours(currentPosition, cube);

                cube[currentPosition.Level, currentPosition.Row, currentPosition.Col] = '#';

                foreach (var neighbour in neighbours)
                {
                    //var dgsrghhd = IsExit(neighbour, cube);
                    if (IsExit(neighbour, cube))
                    {
                        return neighbour.Depth + 1;
                    }

                    toVisit.Enqueue(neighbour);
                }
            }

            return -1;
        }

        static bool IsExit(Position position, char[, ,] cube)
        {
            return (position.Level >= levels - 1 && cube[position.Level, position.Row, position.Col] == 'U') || (position.Level <= 0 && cube[position.Level, position.Row, position.Col] == 'D');
        }

        static List<Position> GetNeighbours(Position currentPosition, char[, ,] cube)
        {
            var neighbours = new List<Position>();
            
            //left
            if (currentPosition.Col > 0)
            {
                neighbours.Add(new Position(currentPosition.Level, currentPosition.Row, currentPosition.Col - 1, currentPosition.Depth+1));
            }

            //right
            if (currentPosition.Col < cols - 1)
            {
                neighbours.Add(new Position(currentPosition.Level, currentPosition.Row, currentPosition.Col + 1, currentPosition.Depth + 1));
            }
            
            //forward
            if (currentPosition.Row < rows - 1)
            {
                neighbours.Add(new Position(currentPosition.Level, currentPosition.Row + 1, currentPosition.Col, currentPosition.Depth + 1));
            }
            
            //back
            if (currentPosition.Row > 0)
            {
                neighbours.Add(new Position(currentPosition.Level, currentPosition.Row - 1, currentPosition.Col, currentPosition.Depth + 1));
            }

            //up
            //down
            if (cube[currentPosition.Level, currentPosition.Row, currentPosition.Col] == 'U')
            {
                neighbours.Add(new Position(currentPosition.Level + 1, currentPosition.Row, currentPosition.Col, currentPosition.Depth + 1));
            }

            else if (cube[currentPosition.Level, currentPosition.Row, currentPosition.Col] == 'D')
            {
                neighbours.Add(new Position(currentPosition.Level - 1, currentPosition.Row, currentPosition.Col, currentPosition.Depth + 1));
            }

            neighbours.RemoveAll(pos => cube[pos.Level, pos.Row, pos.Col] == '#');

            return neighbours;
        }
    }
}
