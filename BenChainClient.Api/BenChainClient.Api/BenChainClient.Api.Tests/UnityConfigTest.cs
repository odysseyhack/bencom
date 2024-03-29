using System;
using BenChainClient.Api;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Tests
{
    /// <summary>This class contains parameterized unit tests for UnityConfig</summary>
    [TestClass]
    [PexClass(typeof(UnityConfig))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnityConfigTest
    {
    }
}
