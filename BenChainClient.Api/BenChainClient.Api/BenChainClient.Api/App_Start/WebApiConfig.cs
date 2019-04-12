using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using Newtonsoft.Json;
using Swashbuckle.Application;

namespace BenChainClient.Api
{
  public static class WebApiConfig
  {

   
      public static void Register(HttpConfiguration config)
      {
        config.EnableCors();

        config.MapHttpAttributeRoutes();

        config.Formatters.Add(new BrowserJsonFormatter());

       config.Routes.MapHttpRoute("Swagger UI", "", null, null, new RedirectHandler(message => message.RequestUri.ToString().TrimEnd('/'), "ui/index"));

      config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

      }

      public class BrowserJsonFormatter : JsonMediaTypeFormatter
      {
        public BrowserJsonFormatter()
        {
          SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
          SerializerSettings.Formatting = Formatting.Indented;
        }

        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers,
          MediaTypeHeaderValue mediaType)
        {
          base.SetDefaultContentHeaders(type, headers, mediaType);
          headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
      }
    }

  }

