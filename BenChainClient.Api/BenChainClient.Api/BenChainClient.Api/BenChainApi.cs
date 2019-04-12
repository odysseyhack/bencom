using System;
using BenChain.Api;
using Microsoft.Rest;

namespace BenChainClient.Api
{
  public static class BenChainApi
  {
    static BenChainApi()
    {
      Client = new ApiClient(new Uri(AppSettings.BenChainApiLocation), new BasicAuthenticationCredentials());
    }

    public static IApiClient Client { get; }
  }
}