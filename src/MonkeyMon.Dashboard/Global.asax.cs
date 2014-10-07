using System;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using MonkeyMon.Dashboard.AppStart;

namespace MonkeyMon.Dashboard
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}