﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace InvoiceDiskLast
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


          // routes.MapRoute(
          //"RouteName",
          //"{Index}",
          //new { controller = "Captcha", action = "Index" });

            // default route


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "landing", action = "Index", id = UrlParameter.Optional }
            );


          
        }
    }
}
