using TicTacToeApplication;
using Xunit;

namespace TicTacToeUnitTest
{
    public class WinConditionShould
    {
        [Theory]
        [InlineData("AntiDiagonalWin")]
        [InlineData("DiagonalWin")]
        [InlineData("LeftColumnWin")]
        [InlineData("topRowWin")]
        public void JudgeCorrectWins(string userInput)
        {
            var board = new MockBoard(3,userInput);
            var player = new Player(2);
            var winCondition = new WinCondition(player,board);
            var result = winCondition.HasPlayerWon();
            Assert.True(result);
            
        }
    }
}