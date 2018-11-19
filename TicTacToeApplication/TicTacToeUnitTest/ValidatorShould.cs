using System;
using System.Runtime.InteropServices;
using TicTacToeApplication;
using Xunit;

namespace TicTacToeUnitTest
{
    public class Tests
    {
        [Theory]
        [InlineData("1,1")]
        [InlineData("2,1")]
        [InlineData("2,2")]
        [InlineData("3,3")]
        public void PassValidMoves(string userInput)
        {
            Validator validator = new Validator(new Board(3));
            var result = validator.ValidateUserPlay(userInput);
            Assert.True(result);
        }

        [Theory]
        [InlineData("sadadsa")]
        [InlineData("1,1")]
        [InlineData("0,0")]
        [InlineData("4,4")]
        [InlineData("-1,-1")]
        public void FailInvalaidMoves(string userInput)
        {
            Board board = new Board(3);
            board.UpdateBoard(1,1,"X");
            Validator validator = new Validator(board);
            var result = validator.ValidateUserPlay(userInput);
            Assert.False(result);
        }
    }
}