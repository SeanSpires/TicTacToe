using System.Runtime.InteropServices;
using TicTacToeApplication;
using Xunit;

namespace TicTacToeUnitTest
{
    public class BoardShould
    {
        [Theory]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(1)]
        public void ShouldHandleGridSizesLessThan2(int gridSize)
        {
            var board = new Board(gridSize);
            Assert.Equal(1,board.GetBoardWidth());
            Assert.Equal(1,board.GetBoardHeight());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(30)]
        public void ShouldReturnCorrectBoardWidth(int boardWidth)
        {
            var board = new Board(boardWidth);
            Assert.Equal(boardWidth,board.GetBoardWidth());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(30)]
        public void ShouldReturnCorrectBoardHeight(int boardHeight)
        {
            var board = new Board(boardHeight);
            Assert.Equal(boardHeight,board.GetBoardHeight());
        }

        [Fact]
        public void ShouldSetUpEmptyBoardOfSize3WhenInstantiated()
        {
            var board = new Board(3);
            Assert.Equal(new [,]
            {
                {".",".","."},
                {".",".","."},
                {".",".","."}
            },board.GetPlayField());
        }

        [Fact]
        public void ShouldUpdateBoard()
        {
            const string playerSymbol = "X";
            var board = new Board(3);
            board.UpdateBoard(1,1,playerSymbol);
            Assert.Equal(new [,]
            {
                {"X",".","."},
                {".",".","."},
                {".",".","."}
            },board.GetPlayField());
        }

        [Fact]
        public void ShouldSetUpEmptyBoardOfSize5WhenInstantiated()
        {
            var board = new Board(5);  
            Assert.Equal(new [,]
            {
                {".",".",".",".","."},
                {".",".",".",".","."},
                {".",".",".",".","."},
                {".",".",".",".","."},
                {".",".",".",".","."}
            },board.GetPlayField());
        }
    }
    
        
}