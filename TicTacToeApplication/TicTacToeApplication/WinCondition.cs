using System;

namespace TicTacToeApplication
{
    public class WinCondition
    {
        private Player player;
        private Board board;
        private string[,] playField;
        private int targetSum;

        public WinCondition(Player player, Board board)
        {
            this.player = player;
            this.board = board;
            playField = board.getPlayField();
            targetSum = Game.calculateGameValues(player.getPlayerSymbol()) * Math.Min(playField.GetLength(0),
                            playField.GetLength(1));
        }

        public bool hasPlayerWon()
        {
            return checkRowForWin() || checkColForWin() || checkDiagonalForWin() || checkAntiDiagForWin();
        }

        public bool checkRowForWin()
        {
            for (var i = 0; i < playField.GetLength(0); i++)
            {
                var sum = 0;
                for (int j = 0; j < playField.GetLength(1); j++)
                {
                    sum += Game.calculateGameValues(playField[i, j]);
                }

                if (sum == targetSum)
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkColForWin()
        {      
            for (int j = 0; j < playField.GetLength(1); j++)
            {
                var sum = 0;
                for (int i = 0; i < playField.GetLength(0); i++)
                {
                    sum += sum + Game.calculateGameValues(playField[j, i]);                  
                }

                if (sum == targetSum)
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkDiagonalForWin()
        {
            var sum = 0;
            for (int i = 0; i < Math.Min(playField.GetLength(0),playField.GetLength(1)); i++)
            {
                sum += Game.calculateGameValues(playField[i, i]);
            }

            return sum == targetSum;
        }

        public bool checkAntiDiagForWin()
        {
            var sum = 0;
            for (int i = 0; i < Math.Min(playField.GetLength(0),playField.GetLength(1)); i++)
            {
                sum += Game.calculateGameValues(playField[playField.GetLength(0) - 1 -i,i]);
            }

            return sum == targetSum;    
        }

        public bool isBoardFull()
        {
            for (int i = 0; i < playField.GetLength(0); i++)
            {
                for (int j = 0; j < playField.GetLength(1); j++)
                {
                    if (playField[i, j].Equals("."))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}