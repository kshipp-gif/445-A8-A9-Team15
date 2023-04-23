using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace _445_A8_A9_Team15
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

        void Session_Start(object sender, EventArgs e)
        {
            HttpSessionState session = HttpContext.Current.Session;

            session["UserName"] = "Guest";

            string welcomeMessage = "Welcome, " + session["UserName"].ToString() + ".";
            HttpContext.Current.Response.Write("<script>alert('" + welcomeMessage + "');</script>");
        }
    }
}