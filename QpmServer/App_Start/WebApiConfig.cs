﻿using System.Net.Http.Headers;
using System.Web.Http;

namespace ShellRepo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute("DefaultApi", 
                "api/{controller}/{id}", 
                new {id = RouteParameter.Optional}
                );
        }
    }
}