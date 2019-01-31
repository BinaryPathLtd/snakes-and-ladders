using System.Linq;
using Domain;
using NUnit.Framework;

namespace Tests
{
    [Description(@"As a player
    I want to be able to move my token
    So that I can get closer to the goal")]
    public class TokenCanMoveFeature
    {
        [Test]
        public void GivenGameStarted_WhenTokenPlacedOnBoard_ThenTokenIsOnSquareOne()
        {
            //GivenGameStarted
            //WhenTokenPlacedOnBoard
            var boardSize = 100;
            var playerCount = 1;
            var game = new Game(boardSize, playerCount);
            game.Start();

            //ThenTokenIsOnSquareOne
            Assert.That(game.Players.First()?.TokenPosition, Is.EqualTo(1));
        }

        [Test]
        public void GivenPlayerTokenIsOnSquareOne_WhenTokenMovedThreeSpaces_ThenTokenIsOnSquareFour()
        {
            //GivenPlayerTokenIsOnSquareOne
            var boardSize = 100;
            var playerCount = 1;
            var game = new Game(boardSize, playerCount);
            game.Start();
            Assert.That(game.Players?.First().TokenPosition, Is.EqualTo(1));
            
            //WhenTokenMovedThreeSpaces
            game.Players?.First().Move(3);

            //ThenTokenIsOnSquareFour
            Assert.That(game.Players?.First().TokenPosition, Is.EqualTo(4));
        }

        [Test]
        public void GivenPlayerTokenIsOnSquareOne_WhenTokenMoved3Spaces_AndMoved4Space_ThenTokenPositionIsOnSquareEight()
        {
            //GivenPlayerTokenIsOnSquare1
            var boardSize = 100;
            var playerCount = 1;
            var game = new Game(boardSize, playerCount);
            game.Start();
            Assert.That(game.Players?.First().TokenPosition, Is.EqualTo(1));
            //WhenTokenMoved3Spaces
            game.Players?.First().Move(3);
            //AndMoved4Space
            game.Players?.First().Move(4);
            //ThenTokenPositionIsOnSquareEight
            Assert.That(game.Players?.First().TokenPosition, Is.EqualTo(8));
        }
    }
}