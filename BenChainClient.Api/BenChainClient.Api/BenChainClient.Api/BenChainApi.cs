using System;
using BenChain.Api;
using Microsoft.Rest;

namespace BenChainClient.Api
{
  /// <summary>
  /// 
  /// </summary>
  public static class BenChainApi
  {
    static BenChainApi()
    {
      Client = new ApiClient(new Uri(AppSettings.BenChainApiLocation), new BasicAuthenticationCredentials());
    }

    /// <summary>
    /// 
    /// </summary>
    public static IApiClient Client { get; }
  }
}