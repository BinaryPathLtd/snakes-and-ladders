using System.Linq;
using Domain;
using NUnit.Framework;

namespace Tests
{
    public class Feature1
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
    }
}