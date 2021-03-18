using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ReportHCL
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

                routes.MapRoute(
                name: "MultiParam",
                url: "{controller}/{action}/{id}/{div}/{ros}"
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
             );
            //routes.MapRoute(
            //   name: "CarStock",
            //   url: "{controller}/{action}/{id}",
            //   defaults: new { controller = "Car", action = "CarStock" }
            //);
        }
    }
}
