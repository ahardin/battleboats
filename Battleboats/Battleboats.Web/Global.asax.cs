using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.SignalR;
using Microsoft.AspNet.SignalR;

namespace Battleboats.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegisterAutoFac();
        }

        private void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterHubs(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            var resolver = new AutofacDependencyResolver(container);
            GlobalHost.DependencyResolver = resolver;
        }
    }
}
