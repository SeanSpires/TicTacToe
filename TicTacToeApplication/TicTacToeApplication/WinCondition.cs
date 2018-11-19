using System;

namespace TicTacToeApplication
{
    public class WinCondition
    {
        private readonly string[,] playField;
        private readonly int targetSum;
        private readonly IBoard board;

        public WinCondition(Player player, IBoard board)
        {
            this.board = board;
            playField = board.GetPlayField();
            targetSum = Game.CalculateGameValues(player.GetPlayerSymbol()) * Math.Min(playField.GetLength(0),
                            playField.GetLength(1));
        }

        public bool HasPlayerWon()
        {
            return CheckRowForWin() || CheckColForWin() || CheckDiagonalForWin() || CheckAntiDiagForWin() ||
                   IsBoardFull();
        }

        private bool CheckRowForWin()
        {
            return SumOverArray(board.GetBoardWidth(), board.GetBoardHeight(),true);
        }

        private bool CheckColForWin()
        {
            return SumOverArray(board.GetBoardHeight(), board.GetBoardWidth(),false);
        }

        private bool CheckDiagonalForWin()
        {
            var sum = 0;
            for (var index = 0; index < Math.Min(board.GetBoardWidth(),board.GetBoardHeight()); index++)
            {
                sum += Game.CalculateGameValues(playField[index, index]);
            }

            return sum == targetSum;
        }

        private bool CheckAntiDiagForWin()
        {
            var sum = 0;
            for (var index = 0; index < Math.Min(board.GetBoardWidth(),board.GetBoardHeight()); index++)
            {
                sum += Game.CalculateGameValues(playField[board.GetBoardWidth() - 1 - index,index]);
            }

            return sum == targetSum;    
        }

        private bool IsBoardFull()
        {
            for (var i = 0; i < board.GetBoardWidth(); i++)
            {
                for (var j = 0; j < board.GetBoardHeight(); j++)
                {
                    if (playField[i, j].Equals(board.GetEmptySymbol()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool SumOverArray(int rows, int columns,bool isCheckingRowForWin)
        {
            for (var row = 0; row < rows; row++)
            {
                var sum = 0;
                for (var col = 0; col < columns; col++)
                {
                    if (isCheckingRowForWin)
                    {
                        sum += Game.CalculateGameValues(playField[row, col]);
                    }
                    else
                    {
                        sum += Game.CalculateGameValues(playField[col, row]);
                    }
                }

                if (sum == targetSum)
                {
                    return true;
                }
            }

            return false;
        }

    }
}