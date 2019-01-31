using System.Linq;
using Domain;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    [Description(@"As a player
I want to move my token based on the roll of a die
So that there is an element of chance in the game")]
    public class DiceRollingFeature
    {
        [Test]
        public void GivenGameStarted_WhenPlayerRollsDie_ThenResultsShouldBeBetween1And6()
        {
            //GivenGameStarted
            var boardSize = 100;
            var playerCount = 1;
            var game = new Game(boardSize, playerCount);
            game.Start();

            //WhenPlayerRollsDie
            game.Players?.First().RollDie();

            //ThenResultsShouldBeBetween1And6
            Assert.That(game.Players?.First().TokenPosition, Is.GreaterThan(2));
            Assert.That(game.Players?.First().TokenPosition, Is.LessThan(8));
        }
    }
}