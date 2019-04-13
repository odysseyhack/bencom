using System.Web.Http;
using WebActivatorEx;
using BenChain.Api;
using Swashbuckle.Application;
using Swashbuckle.AutoRestExtensions;
using Swashbuckle.Swagger;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace BenChain.Api
{
  public class SwaggerConfig
  {
    public static void Register()
    {
      var thisAssembly = typeof(SwaggerConfig).Assembly;

      GlobalConfiguration.Configuration
        .EnableSwagger(c =>
        {
          c.SingleApiVersion("v1", "BenChain.Api")
            .Description("BenChain API 2019.")
            .Contact(cc => cc
              .Name("BencomGroup BV")
              .Url("https://www.bencom.nl/")
              .Email("developers@bencom.nl")
            );
          c.IncludeXmlComments(GetXmlCommentsPath("/App_Data/ApiDoc.xml"));
          c.MapType<decimal>(() => new Schema { type = "number", format = "decimal" });
          c.MapType<decimal?>(() => new Schema { type = "number", format = "decimal" });

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
          c.InjectStylesheet(thisAssembly, "BenChain.Api.SwaggerUI.custom.css");
          c.InjectJavaScript(thisAssembly, "BenChain.Api.SwaggerUI.custom.js");

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
