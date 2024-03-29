using System;
using BenChainClient.Api.Config;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Config.Tests
{
    /// <summary>This class contains parameterized unit tests for BenChainPortfolioAutoMapperConfig</summary>
    [TestClass]
    [PexClass(typeof(BenChainPortfolioAutoMapperConfig))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BenChainPortfolioAutoMapperConfigTest
    {
    }
}
