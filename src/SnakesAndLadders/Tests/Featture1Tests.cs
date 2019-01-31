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
            var boardSize = 100;
            var playerCount = 1;
            //GivenGameStarted
            //WhenTokenPlacedOnBoard
            var game = new Game(boardSize, playerCount);
            game.Start();

            //ThenTokenIsOnSquareOne
            Assert.That(game.Players.First()?.TokenPosition, Is.EqualTo(1));
        }
    }
}