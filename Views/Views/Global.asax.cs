using System;
using System.Web.Mvc;
using System.Web.Routing;
using Views.Infrastructure;

namespace Views
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Add((new DebugDataViewEngine()));
        }
    }
}