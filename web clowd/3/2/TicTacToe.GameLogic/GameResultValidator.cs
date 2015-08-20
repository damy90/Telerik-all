using System;
namespace TicTacToe.GameLogic
{
    public class GameResultValidator : IGameResultValidator
    {
        // O-X
        // O-X
        // --X

        private static readonly int[,] winningPositions = new int[,]
        {
            { 0, 1, 2 },
            { 3, 4, 5 },
            { 6, 7, 8 },
            { 0, 3, 6 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 0, 4, 8 },
            { 2, 4, 6 }
        };

        public GameResult GetResult(string board)
        {
            var wonByO = IfPlayerWins(board, 'O');
            var wonByX = IfPlayerWins(board, 'X');

            if (board.Length!=9)
            {
                throw new ArgumentException("Invalid game field size!");
            }

            if (wonByO == true && wonByX == true)
            {
                throw new ApplicationException("Invalid game state! Only one player can win!");
            }

            if (wonByO)
            {
                return GameResult.WonByO;
            }

            if (wonByX)
            {
                return GameResult.WonByX;
            }

            if (board.IndexOf('-') != -1)
            {
                return GameResult.NotFinished;
            }

            return GameResult.Draw;
        }

        public bool IfPlayerWins(string board, char sign)
        {
            for (int i = 0; i < winningPositions.GetLength(0); i++)
            {
                for (int j = 0, matchcount=0; j < winningPositions.GetLength(1); j++)
                {
                    if (board[winningPositions[i, j]] == sign)
                    {
                        matchcount++;
                    }

                    if (matchcount == winningPositions.GetLength(1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
