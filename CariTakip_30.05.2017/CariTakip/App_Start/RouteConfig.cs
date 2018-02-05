using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CariTakip
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Error","error/notfound",new {action="NotFound", controller="Error"});
            routes.MapRoute("Login", "login", new { action = "Login", controller = "Auth" });
            routes.MapRoute("Anasayfa", "", new { action = "Index", controller = "Anasayfa" });
            routes.MapRoute("Musteriler",
            url: "musteriler/{action}",
            defaults: new { controller = "Musteriler", action = "Index" });

            routes.MapRoute("Logout", "logout", new { action = "Logout", controller = "Auth" });

        }
    }
}
