using System.Web.Http;
using WebActivatorEx;
using BenChainClient.Api;
using Swashbuckle.Application;
using Swashbuckle.AutoRestExtensions;
using Swashbuckle.Swagger;


[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace BenChainClient.Api
{
  public class SwaggerConfig
  {
    public static void Register()
    {
      var thisAssembly = typeof(SwaggerConfig).Assembly;

      GlobalConfiguration.Configuration
        .EnableSwagger(c =>
        {
          c.SingleApiVersion("v1", "BenChainClient.Api")
            .Description("BenChain Client API 2019.")
            .Contact(cc => cc
              .Name("BencomGroup BV")
              .Url("https://www.bencom.nl/")
              .Email("developers@bencom.nl")
            );
          c.IncludeXmlComments(GetXmlCommentsPath("/App_Data/ApiDoc.xml"));
          c.MapType<decimal>(() => new Schema {type = "number", format = "decimal"});
          c.MapType<decimal?>(() => new Schema {type = "number", format = "decimal"});

          c.ApplyAutoRestFilters(
            new SwaggerDocsConfigExtensionsConfiguration()
            {
              ApplyEnumTypeSchemaFilter = false,
              ApplyNullableTypeSchemaFilter = true,
              ApplyNonNullableAsRequiredSchemaFilter = false
            },
            null);

          c.DescribeAllEnumsAsStrings();

        })
        .EnableSwaggerUi("ui/{*assetPath}", c =>
        {
          c.InjectStylesheet(thisAssembly, "BenChainClient.Api.SwaggerUI.custom.css");
          c.InjectJavaScript(thisAssembly, "BenChainClient.Api.SwaggerUI.custom.js");

          c.DocExpansion(DocExpansion.List);

          c.SupportedSubmitMethods("GET", "HEAD", "POST");
        });
    }

    private static string GetXmlCommentsPath(string virtualPath)
    {
      return System.Web.Hosting.HostingEnvironment.MapPath(virtualPath);
    }

  }
}

