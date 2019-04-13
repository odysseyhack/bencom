using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BenChainClient.Api
{
  public static class AppSettings
  {
    public static string BenChainApiLocation => ConfigurationManager.AppSettings["BenChainApiLocation"];
    public static string fileUploadFolder => ConfigurationManager.AppSettings["fileUploadFolder"];
  }
}