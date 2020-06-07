using Swashbuckle.Application;
using System.Net.Http.Headers;
using System.Web.Http;

namespace teacher_recruitment_app
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Redirect root to Swagger UI
            config.Routes.MapHttpRoute(
			    name: "Swagger UI",
			    routeTemplate: "",
			    defaults: null,
			    constraints: null,
			    handler: new RedirectHandler(SwaggerDocsConfig.DefaultRootUrlResolver, "swagger")
            );
        }
    }
}
