namespace TicTacToeApplication
{
    internal class TicTacToe
    {
        public static void Main(string[] args)
        {
            var game = new Game(2);
            game.start();
        }
    }
}