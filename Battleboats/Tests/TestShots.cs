using System;
using System.Linq;
using Battleboats.Domain;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CreateGameTests
    {

        [Test]
        public void GameContainsAllShips()
        {
            var game = new Game();

            Assert.AreEqual(5, game.AvailableShips.Count);
        }
    }
}
