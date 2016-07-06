using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace Attractions
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver =
              new CamelCasePropertyNamesContractResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/attractions/{id}",
                defaults: new { controller = "attractions", id = RouteParameter.Optional }
             );

            config.Routes.MapHttpRoute(
                name: "FeaturedAttractions",
                routeTemplate: "api/v1/featured/{id}",
                defaults: new { controller = "featured", id = RouteParameter.Optional }
             );

            config.Routes.MapHttpRoute(
                name: "Favourites",
                routeTemplate: "api/v1/favourites/{id}",
                defaults: new { controller = "favourites", id = RouteParameter.Optional }
             );

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
