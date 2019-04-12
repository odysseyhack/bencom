using System;
using BenChainClient.Api;
using Microsoft.Rest;

namespace BenChain.Api.Helpers
{
  public class BenChainClientApi
  {
    static BenChainClientApi()
    {
      Client = new ApiClient(new Uri(AppSettings.BenChainClientApiLocation), new BasicAuthenticationCredentials());
    }

    public static IApiClient Client { get; }
  }
}