using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Battleboats.Web.Startup))]
namespace Battleboats.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
