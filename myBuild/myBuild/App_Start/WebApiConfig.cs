using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;

namespace myBuild.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
          name: "RepliesRoute",
          routeTemplate: "api/v1/topics/{topicid}/replies/{id}",
          defaults: new { controller = "replies", id = RouteParameter.Optional }

      );

           config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/v1/topics/{id}",
          defaults: new { controller = "topics", id = RouteParameter.Optional }

      );
           //var json = config.Formatters.JsonFormatter;
           //json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
           var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
           jsonFormatter.SerializerSettings.ContractResolver =
             new CamelCasePropertyNamesContractResolver();

           config.Formatters.Remove(config.Formatters.XmlFormatter);
            
        }
    }
}