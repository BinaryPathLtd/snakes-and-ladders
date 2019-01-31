using System.Linq;
using Domain;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    [Description(@"As a player
    I want to be able to win the game
    So that I can gloat to everyone around")]
    public class PlayerCanWinGameFeature
    {
        [Test]
        public void GivenTokenOnSquareNintySeven_WhenMovingThreeSpaces_ThenTokenIsOnSquare100AndPlayerWinsGame()
        {
            //GivenTokenOnSquareNintySeven
            var boardSize = 100;
            var playerCount = 1;
            var game = new Game(boardSize, playerCount);
            game.Start();
            game.Players?.First().Move(96);
            
            //WhenMovingThreeSpaces
            game.Players?.First().Move(3);
            
            //ThenTokenIsOnSquare100
            Assert.That(game.Players?.First().TokenPosition, Is.EqualTo(100));
            //AndPlayerWinsGame
            Assert.That(game.HasBeenWon, Is.EqualTo(true));
        }
    }
}
