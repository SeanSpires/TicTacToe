using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TicTacToeApplication
{
    public class Validator
    {
        private readonly IBoard board;
        
        public Validator(IBoard board)
        {
            this.board = board;
        }

        public static bool ValidateNumberOfPlayers(string userInput)
        {
            if (!int.TryParse(userInput, out var numberOfPlayers)) return false;
            
            return numberOfPlayers > 0;
        }

        public bool ValidateUserPlay(string userInput)
        {
            try
            {
                var coordinateMatch = Regex.Match(userInput, @"^[1-"+board.GetBoardWidth()+"],[1-"+board.GetBoardHeight()+"]$");
                var coordinates = userInput.Split(',').Select(int.Parse).ToList();
                
                if (!coordinateMatch.Success)
                {
                    return false;
                }
                
                if (board.GetBoardElement(coordinates[0] - 1, coordinates[1] - 1) == ".") return true;
                
                Console.WriteLine("Those coordinates have already been selected");
                return false;

            }
            catch (FormatException e)
            {
                return false;
            }
        }
    }
}