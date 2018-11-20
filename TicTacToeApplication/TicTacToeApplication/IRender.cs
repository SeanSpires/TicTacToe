namespace TicTacToeApplication
{
    public interface IRender
    {
        void DisplayBoard(IBoard board);
        void DisplayNumberOfPlayersError();
        void DisplayStartTurn(Player player);
    }
}