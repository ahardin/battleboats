using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Battleboats.Domain;
using Battleboats.Infrastructure.Repositories;
using Battleboats.Web.Models;
using Microsoft.AspNet.SignalR;

namespace Battleboats.Web.Hubs
{
    public class BattleBoatsHub : Hub
    {
        private readonly IGameService _gameService;
        private Game _game;

        public BattleBoatsHub(IGameService gameService)
        {
            _gameService = gameService;
        }

        /// <summary>
        /// Returns to the calling client the current DateTime
        /// </summary>
        public void Ping()
        {
            Clients.Caller.Pong(DateTime.UtcNow);
        }

        /// <summary>
        /// Creates a new user if the username does not exist, else finds the existing user, returns the userid
        /// </summary>
        /// <param name="username"></param>
        public void Join(string username)
        {
            var userId = Guid.Parse("2B0F4297-5372-451F-A1DC-1D98139D5FD3");
            //var userId = Guid.NewGuid();
            Clients.Caller.JoinResponse(userId);
        }

        public void CreateGame(Guid userId)
        {
            _game = new Game(new Player() { IsPlayerTurn = true, Name = "Player 1", PlayerId = userId });
            Clients.Caller.CreateGameResponse(_game.GameId);
        }

        public void JoinGame(Guid userId)
        {
            _game.PlayerTwo = new Player()  { IsPlayerTurn = false, Name = "Player 2", PlayerId = userId };
            Clients.Caller.JoinGameResponse(_game.GameId);
        }

        public void FireShot(Guid userId, Coordinate fire) //  Guid gameId -- Assumed only one game right now
        {
            _game.FireShot(userId, fire);
        }

        public void SetupShip(Guid userId, Guid gameId)
        {
            
        }

    }
}