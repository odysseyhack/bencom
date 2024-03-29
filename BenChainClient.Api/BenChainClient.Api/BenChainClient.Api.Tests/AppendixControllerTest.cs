using System.Threading.Tasks;
using System.Web.Http;
using System;
using BenChainClient.Api.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for AppendixController</summary>
    [TestClass]
    [PexClass(typeof(AppendixController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AppendixControllerTest
    {

    /// <summary>Test stub for UploadFilesByPost()</summary>
    [PexMethod]
    public Task<IHttpActionResult> UploadFilesByPostTest([PexAssumeUnderTest]AppendixController target)
    {
      Task<IHttpActionResult> result = target.UploadFilesByPost();
      return result;
    }
  }
}
