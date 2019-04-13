using System;
using BenChainClient.Api;
using Microsoft.Rest;

namespace BenChain.Api.Helpers
{
  public static class BenChainClientApi
  {
    static BenChainClientApi()
    {
      Client = new ApiClient(new Uri(AppSettings.BenChainClientApiLocation), new BasicAuthenticationCredentials());
    }

    public static IApiClient Client { get; }
  }
}