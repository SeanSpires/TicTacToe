using Xunit;

namespace TicTacToeUnitTest
{
    public class RenderShould
    {
        [Fact]
        public void ShouldPrintAEmptyBoard()
        {
            var mockBoard = new MockBoard(3,"empty");
            var mockRender = new MockRender();
            mockRender.DisplayBoard(mockBoard);
            Assert.Equal(new[,]
            {
                {".",".","."},
                {".",".","."},
                {".",".","."}
            },mockRender.getPrintedOutput());
        }

        [Fact]
        public void ShouldPrintANonEmptyBoard()
        {
            var mockBoard = new MockBoard(3,"LeftColumnWin");
            var mockRender = new MockRender();
            mockRender.DisplayBoard(mockBoard);
            Assert.Equal(new [,]
            {
                {"X",".","."},
                {"X",".","."},
                {"X",".","."}
            },mockRender.getPrintedOutput());

        }

    }
}