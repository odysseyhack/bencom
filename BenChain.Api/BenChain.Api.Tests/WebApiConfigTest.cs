using System.Web.Http;
using System;
using BenChain.Api;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChain.Api.Tests
{
    /// <summary>This class contains parameterized unit tests for WebApiConfig</summary>
    [TestClass]
    [PexClass(typeof(WebApiConfig))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class WebApiConfigTest
    {

    /// <summary>Test stub for Register(HttpConfiguration)</summary>
    [PexMethod]
    public void RegisterTest(HttpConfiguration config)
    {
      WebApiConfig.Register(config);
      
    }
  }
}
