using System;

namespace TicTacToeApplication
{
    public class WinCondition
    {
        private readonly string[,] playField;
        private readonly int targetSum;

        public WinCondition(Player player, Board board)
        {
            playField = board.getPlayField();
            targetSum = Game.calculateGameValues(player.getPlayerSymbol()) * Math.Min(playField.GetLength(0),
                            playField.GetLength(1));
        }

        public bool hasPlayerWon()
        {
            return checkRowForWin() || checkColForWin() || checkDiagonalForWin() || checkAntiDiagForWin() ||
                   isBoardFull();
        }

        public bool checkRowForWin()
        {
            for (var row = 0; row < Board.getBoardWidth(); row++)
            {
                var sum = 0;
                for (var col = 0; col < Board.getBoardHeight(); col++)
                {
                    sum += Game.calculateGameValues(playField[row, col]);
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
            for (int col = 0; col < playField.GetLength(1); col++)
            {
                var sum = 0;
                for (int i = 0; i < playField.GetLength(0); i++)
                {
                    sum += sum + Game.calculateGameValues(playField[col, i]);                  
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
            for (int index = 0; index < Math.Min(Board.getBoardWidth(),Board.getBoardHeight()); index++)
            {
                sum += Game.calculateGameValues(playField[index, index]);
            }

            return sum == targetSum;
        }

        public bool checkAntiDiagForWin()
        {
            var sum = 0;
            for (int index = 0; index < Math.Min(Board.getBoardWidth(),Board.getBoardHeight()); index++)
            {
                sum += Game.calculateGameValues(playField[Board.getBoardWidth() - 1 -index,index]);
            }

            return sum == targetSum;    
        }

        public bool isBoardFull()
        {
            for (int i = 0; i < Board.getBoardWidth(); i++)
            {
                for (int j = 0; j < Board.getBoardHeight(); j++)
                {
                    if (playField[i, j].Equals(Board.getEmptySymbol()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool checkRowOrColForWin(int rows, int columns)
        {   
            for (int row = 0; row < rows; rows++)
            {
                var sum = 0;
                
                for (int col = 0; col < columns; columns++)
                {
                    sum += sum + Game.calculateGameValues(playField[row,col]);                  
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