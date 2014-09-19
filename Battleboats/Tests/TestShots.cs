using System;
using System.Linq;
using Battleboats.Domain;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CreateGameTests
    {

        [TestCase("Battleship")]
        [TestCase("Aircraft Carrier")]
        [TestCase("Patrol Boat")]
        [TestCase("Destroyer")]
        [TestCase("Submarine")]
        public void GameContainsAvailableShip(string shipName)
        {
            var game = new Game(new Player());
            Assert.That(game.AvailableShips.Any(s=> s.Name == shipName));
        }

        [Test]
        public void GenerateGameId()
        {
            var game = new Game(new Player());

            Assert.IsNotNull(game.GameId);
        }

    }
}
