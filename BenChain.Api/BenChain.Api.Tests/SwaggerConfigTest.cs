using System;
using BenChain.Api;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChain.Api.Tests
{
    /// <summary>This class contains parameterized unit tests for SwaggerConfig</summary>
    [TestClass]
    [PexClass(typeof(SwaggerConfig))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SwaggerConfigTest
    {

    /// <summary>Test stub for Register()</summary>
    [PexMethod]
    public void RegisterTest()
    {
      SwaggerConfig.Register();
      
    }
  }
}
