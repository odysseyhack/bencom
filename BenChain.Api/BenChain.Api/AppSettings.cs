using System.Configuration;

namespace BenChain.Api
{
  public class AppSettings
  {
    public static string BenChainClientApiLocation => ConfigurationManager.AppSettings["BenChainClientApiLocation"];
  }
}