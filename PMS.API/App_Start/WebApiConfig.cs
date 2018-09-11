using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace PMS.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            DiConfiguration(config);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void DiConfiguration(HttpConfiguration config)
        {            
            var containerBuilder = new ContainerBuilder();            
            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            var container = AutofacConfig.RegisterAutofac(containerBuilder);
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
