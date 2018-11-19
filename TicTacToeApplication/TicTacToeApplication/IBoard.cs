namespace TicTacToeApplication
{
    public interface IBoard
    {
        void UpdateBoard(int row, int col, string symbol);
        string GetBoardElement(int row, int col);
        string[,] GetPlayField();
        int GetBoardHeight();
        int GetBoardWidth();
        string GetEmptySymbol();
    }
}