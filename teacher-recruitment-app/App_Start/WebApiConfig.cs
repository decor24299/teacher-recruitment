using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Web.Http;
using teacher_recruitment_app.Utilities;

namespace teacher_recruitment_app
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
