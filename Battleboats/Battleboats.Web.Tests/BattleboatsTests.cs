using System;
using Battleboats.Web.Hubs;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Battleboats.Web.Tests
{

    public interface IClientContract
    {
        void Pong(DateTime datetime);
        void JoinResponse(Guid userId);
    }

    [TestClass]
    public class BattleBoatsHubTests
    {
        [TestMethod]
        public void TestPing()
        {
            var hub = new BattleBoatsHub();
            var mockClients = new Mock<IHubCallerConnectionContext<dynamic>>();
            var mockCaller = new Mock<IClientContract>();
            hub.Clients = mockClients.Object;
            mockCaller.Setup(s => s.Pong(It.IsAny<DateTime>())).Verifiable();
            mockClients.Setup(s => s.Caller).Returns(mockCaller.Object);

            hub.Ping();

            mockCaller.VerifyAll();
        }

        [TestMethod]
        public void TestJoin()
        {
            var hub = new BattleBoatsHub();
            var mockClients = new Mock<IHubCallerConnectionContext<dynamic>>();
            var mockCaller = new Mock<IClientContract>();
            hub.Clients = mockClients.Object;
            var userId = Guid.Parse("2B0F4297-5372-451F-A1DC-1D98139D5FD3");
            mockCaller.Setup(s => s.JoinResponse(userId)).Verifiable();
            mockClients.Setup(s => s.Caller).Returns(mockCaller.Object);

            hub.Join("testuser");

            mockCaller.VerifyAll();
        }

    }
}
