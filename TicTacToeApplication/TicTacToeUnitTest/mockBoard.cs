using TicTacToeApplication;

namespace TicTacToeUnitTest
{
    public class MockBoard : IBoard
    {
        private string winType;
        private int size;
        private string[,] playField;
       
        
        public MockBoard(int size,string winType)
        {
            this.size = size;
            this.winType = winType;
            constructBoard(winType);
        }

        public void UpdateBoard(int row,int col,string symbol)
        {
            playField[row - 1, col - 1] = symbol;
        }



        public string GetBoardElement(int row, int col)
        {
            return playField[row,col];
        }

        public string[,] GetPlayField()
        {
            return playField;
        }

        public int GetBoardHeight()
        {
            return 3;
        }

        public int GetBoardWidth()
        {
            return 3;
        }

        public string GetEmptySymbol()
        {
            return ".";
        }

        private void constructBoard(string winType)
        {
            switch (winType)
            {
                case "topRowWin":
                    playField =  new string[,]
                    {
                        {"X","X","X"},
                        {".",".","."},
                        {".",".","."}
                    };                  
                    break;
                case "LeftColumnWin":
                    playField =  new string[,]
                    {
                        {"X",".","."},
                        {"X",".","."},
                        {"X",".","."}
                    };                  
                    break;
                case "DiagonalWin":
                    playField =  new string[,]
                    {
                        {"X",".","."},
                        {".","X","."},
                        {".",".","X"}
                    };                  
                    break;
                case "AntiDiagonalWin":
                    playField =  new string[,]
                    {
                        {"X",".","X"},
                        {".","X","."},
                        {"X",".","."}
                    };                  
                    break;
                case "NonWin1":
                    playField =  new string[,]
                    {
                        {"X",".","X"},
                        {".","O","."},
                        {"X",".","."}
                    };                  
                    break;
                case "NonWin2":
                    playField =  new string[,]
                    {
                        {"X",".","X"},
                        {".",".","."},
                        {"X",".","."}
                    };                  
                    break;
                default:
                    playField = new string[,]
                    {
                        {".",".","."},
                        {".",".","."},
                        {".",".","."}
                    };
                    break;
                    
            }
        }
    }
}