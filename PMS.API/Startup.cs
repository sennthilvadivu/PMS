using Microsoft.ApplicationInsights.Extensibility;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace PMS.API
{
    /// <summary>
    /// Startup Class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configuration
        /// </summary>
        /// <param name="app">AppBuilder Interface</param>
        public void Configuration()
        {
            var httpConfig = new HttpConfiguration();            

            DiConfiguration(httpConfig);
            WebApiConfig.Register(httpConfig);
            SwaggerConfig.Register(httpConfig);            
        }

       
        /// <summary>
        /// DI Configuration
        /// </summary>
        /// <param name="config">HttpConfiguration Object</param>
        private static void DiConfiguration(HttpConfiguration config)
        {
            //Load Autofac json
            var configBuilder = new ConfigurationBuilder();
            configBuilder.AddJsonFile(Constants.AutofacJsonFileName);

            var containerBuilder = new ContainerBuilder();

            // Register autofac configuration to container
            var module = new ConfigurationModule(configBuilder.Build());
            containerBuilder.RegisterModule(module);

            // Inject DB Context
            containerBuilder.RegisterType<Simplify.Infrastructure.Persistence.SimplifyContext>().InstancePerRequest();

            // Inject Simplify Repository
            containerBuilder.RegisterGeneric(typeof(Simplify.Infrastructure.Persistence.SimplifyRepository<>))
                            .As(typeof(Core.Persistence.ISimplifyRepository<>));

            // Inject Mapper
            AutoMapperConfig.Configure();
            containerBuilder.Register(mapperInstance => new MapperConfiguration(profileConfiguration => { profileConfiguration.AddProfile(new MappingProfile()); })).AsSelf()
                .SingleInstance();
            containerBuilder.Register(containerInstance => containerInstance.Resolve<MapperConfiguration>().CreateMapper(containerInstance.Resolve)).As<IMapper>()
                .InstancePerRequest();

            // Register your Web API controllers.
            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = containerBuilder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
