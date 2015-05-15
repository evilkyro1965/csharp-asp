using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace Webapi_Basic
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute("Default API Route",
                "api/1.0/{controller}/{id}",
                new
                {
                    id = RouteParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // The Web API Configuration Object
            var config = GlobalConfiguration.Configuration;

            // Remove the XML Formatter
            var xmlFormatter = config.Formatters
              .Where(f =>
              {
                  return f.SupportedMediaTypes.Any(v => v.MediaType == "text/xml");
              })
              .FirstOrDefault();

            if (xmlFormatter != null)
            {
                config.Formatters.Remove(xmlFormatter);
            }


        }
    }
}
