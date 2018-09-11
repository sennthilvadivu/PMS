using Autofac;
using Autofac.Integration.WebApi;
using PMS.Core.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace PMS.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var httpConfig = new HttpConfiguration();

            //DiConfiguration(httpConfig);
            WebApiConfig.Register(httpConfig);
            SwaggerConfig.Register(httpConfig);

            GlobalConfiguration.Configure(WebApiConfig.Register);
            //ContainerConfig.Configure();
        }
    }

    //public static class ContainerConfig
    //{
    //    private static Autofac.IContainer _container;

    //    public static Autofac.IContainer GetContainer()
    //    {
    //        if (_container != null)
    //            return _container;

    //        var builder = new ContainerBuilder();

    //        builder.RegisterType<VentureApplication>()
    //           .AsSelf()
    //           .InstancePerLifetimeScope()
    //           .AsImplementedInterfaces();

    //        _container = builder.Build();

    //        return _container;
    //    }

    //    public static Autofac.IContainer Configure()
    //    {
    //        var container = GetContainer();

    //        var webApiResolver = new AutofacWebApiDependencyResolver(container);
    //        GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;

    //        return container;
    //    }
    //}
}
