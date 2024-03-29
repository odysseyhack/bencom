using System;
using BenChain.Api.Helpers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChain.Api.Helpers.Tests
{
    /// <summary>This class contains parameterized unit tests for BenChainClientApi</summary>
    [TestClass]
    [PexClass(typeof(BenChainClientApi))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BenChainClientApiTest
    {
    }
}
