using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleboats.Domain
{
    public class Game
    {
        public Guid GameId { get; set; }

        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public List<Ship> AvailableShips
        {
            get
            {
                return new List<Ship>
                    {
                        new Ship() {Id = 1, Name = "Aircraft Carrier", Size = 5},
                        new Ship() {Id = 2, Name = "Battleship", Size = 4},
                        new Ship() {Id = 3, Name = "Submarine", Size = 3},
                        new Ship() {Id = 4, Name = "Destroyer", Size = 3},
                        new Ship() {Id = 5, Name = "Patrol Boat", Size = 2},
                    };
            }
        }

        public ShotResult FireShot(Guid shootingPlayerId, Coordinate coords)
        {
            throw new NotImplementedException();
        }

        public bool SetShip(Guid shootingPlayerId, Ship ship)
        {
            throw new NotImplementedException();   
        }
    }

    public class ShotResult
    {
        public bool WasHit { get; set; }
        public bool EndsGame { get; set; }
    }

    public class Player
    {
        public string Name { get; set; }
        public Guid PlayerId { get; set; }
        public bool IsPlayerTurn { get; set; }
        public IEnumerable<Ship> Ships { get; set; }
    }

    public class Ship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public Coordinate Head { get; set; }
        public Coordinate Tail { get; set; }
    }

    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
