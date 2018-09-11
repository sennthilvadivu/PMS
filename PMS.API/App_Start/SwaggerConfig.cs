using Swashbuckle.Application;
using System.Web.Http;
using System.Web.Mvc;

namespace PMS.API
{
    public static class SwaggerConfig
    {
        /// <summary>
        /// Register Method
        /// </summary>
        public static void Register(HttpConfiguration configuration)
        {
            //configuration.EnableSwagger(swaggerConfigurationInstance =>
            //{
            //    swaggerConfigurationInstance.SingleApiVersion("v1", "PMS API");
            //    var docFile = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "App_Data\\PMSApiDoc.xml");
            //    swaggerConfigurationInstance.IncludeXmlComments(docFile);
            //    //swaggerConfigurationInstance.OperationFilter<RequiredHeaderParameter>();
            //    swaggerConfigurationInstance.DescribeAllEnumsAsStrings();
            //})
            //    .EnableSwaggerUi(c =>
            //    {
            //        c.EnableDiscoveryUrlSelector();
            //    });

            GlobalConfiguration.Configuration
  .EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"))
  .EnableSwaggerUi();
        }
    }
}