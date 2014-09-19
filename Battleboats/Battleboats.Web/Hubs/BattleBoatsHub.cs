using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Battleboats.Web.Hubs
{
    public class BattleBoatsHub : Hub
    {
        public BattleBoatsHub()
        {
            
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




    }
}