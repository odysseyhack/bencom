using BenChainClient.Api.Models;
// <copyright file="ContextControllerTest.cs">Copyright ©  2019</copyright>
using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ContextController</summary>
    [PexClass(typeof(ContextController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ContextControllerTest
    {
    /// <summary>Test stub for GetAll()</summary>
    [PexMethod]
    public Task<IHttpActionResult> GetAllTest([PexAssumeUnderTest]ContextController target)
    {
      Task<IHttpActionResult> result = target.GetAll();
      return result;
    }

    /// <summary>Test stub for CreatedOrUpdate(ContextModel)</summary>
    [PexMethod]
    public Task<IHttpActionResult> CreatedOrUpdateTest([PexAssumeUnderTest]ContextController target, ContextModel contextModel)
    {
      Task<IHttpActionResult> result = target.CreatedOrUpdate(contextModel);
      return result;
    }

    /// <summary>Test stub for UpdateBenChainStatus(BenChainContextModel)</summary>
    [PexMethod]
    public Task<IHttpActionResult> UpdateBenChainStatusTest([PexAssumeUnderTest]ContextController target, BenChainContextModel benchainContextModel)
    {
      Task<IHttpActionResult> result = target.UpdateBenChainStatus(benchainContextModel);
      return result;
    }
  }
}
