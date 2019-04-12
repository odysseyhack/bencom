using System.Web.Http;
using BenChainClient.Api.Config;

namespace BenChainClient.Api
{
  public class WebApiApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      GlobalConfiguration.Configure(WebApiConfig.Register);
      UnityConfig.RegisterComponents();
      BenChainPortfolioAutoMapperConfig.Init();
    }
  }
}
