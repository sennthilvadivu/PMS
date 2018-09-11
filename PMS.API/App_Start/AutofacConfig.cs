using Autofac;
using PMS.Core.Application;
using PMS.Core.Repositories;
using PMS.Persistence;
using PMS.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.API
{
    public class AutofacConfig
    {
        public static IContainer RegisterAutofac(ContainerBuilder containerBuilder)
        {
            //Inject Services
            //containerBuilder.RegisterType<ContactService>().As<IContactService>();
            containerBuilder.RegisterType<VentureApplication>().As<IVentureApplication>();


            containerBuilder.RegisterType<VentureRepository>().As<IVentureRepository>();

            //Inject context
            containerBuilder.RegisterType<PMSContext>();

            return containerBuilder.Build();
        }
    }
}