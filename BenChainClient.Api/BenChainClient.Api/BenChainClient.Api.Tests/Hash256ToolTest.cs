using System;
using BenChainClient.Api.Helpers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Helpers.Tests
{
    /// <summary>This class contains parameterized unit tests for Hash256Tool</summary>
    [TestClass]
    [PexClass(typeof(Hash256Tool))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Hash256ToolTest
    {

    /// <summary>Test stub for Sha256File(String)</summary>
    [PexMethod]
    public string Sha256FileTest(string inputFilePath)
    {
      string result = Hash256Tool.Sha256File(inputFilePath);
      return result;
      // TODO: add assertions to method Hash256ToolTest.Sha256FileTest(String)
    }

    /// <summary>Test stub for Sha256HashString(String)</summary>
    [PexMethod]
    public string Sha256HashStringTest(string inputString)
    {
      string result = Hash256Tool.Sha256HashString(inputString);
      return result;
      // TODO: add assertions to method Hash256ToolTest.Sha256HashStringTest(String)
    }

    /// <summary>Test stub for Md5HashString(String)</summary>
    [PexMethod]
    public string Md5HashStringTest(string inputString)
    {
      string result = Hash256Tool.Md5HashString(inputString);
      return result;
      // TODO: add assertions to method Hash256ToolTest.Md5HashStringTest(String)
    }
  }
}
