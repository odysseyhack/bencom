using System.Web.Http;
using Unity;
using Unity.WebApi;
using BenChainClient.Api.Servicies;

namespace BenChainClient.Api
{
  public static class UnityConfig
  {
    public static void RegisterComponents()
    {
      var container = new UnityContainer();

      RegisterServices(container);

      GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
    }

    private static void RegisterServices(UnityContainer container)
    {
      container.RegisterType<IParticipantService, ParticipantService>();
      container.RegisterType<IContextService, ContextService>();
    }
  }
}