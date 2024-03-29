using BenChainClient.Api.Models;
using System.Threading.Tasks;
using System.Web.Http;
using System;
using BenChainClient.Api.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for SignatorController</summary>
    [TestClass]
    [PexClass(typeof(SignatorController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SignatorControllerTest
    {

    /// <summary>Test stub for GetAll()</summary>
    [PexMethod]
    public Task<IHttpActionResult> GetAllTest([PexAssumeUnderTest] SignatorController target)
    {
      Task<IHttpActionResult> result = target.GetAll();
      return result;
    }


    /// <summary>Test stub for CreatedOrUpdate(SignatoryModel)</summary>
    [PexMethod]
    public Task<IHttpActionResult> CreatedOrUpdateTest([PexAssumeUnderTest]SignatorController target, SignatoryModel participantModel)
    {
      Task<IHttpActionResult> result = target.CreatedOrUpdate(participantModel);
      return result;
    }

    /// <summary>Test stub for BenChainUpdate(SignatoryModel)</summary>
    [PexMethod]
    public Task<IHttpActionResult> BenChainUpdateTest([PexAssumeUnderTest]SignatorController target, SignatoryModel participantModel)
    {
      Task<IHttpActionResult> result = target.BenChainUpdate(participantModel);
      return result;
    }

    /// <summary>Test stub for GetAllNotOpenByParticipant(Guid)</summary>
    [PexMethod]
    public Task<IHttpActionResult> GetAllNotOpenByParticipantTest([PexAssumeUnderTest]SignatorController target, Guid participantId)
    {
      Task<IHttpActionResult> result = target.GetAllNotOpenByParticipant(participantId);
      return result;
      // TODO: add assertions to method SignatorControllerTest.GetAllNotOpenByParticipantTest(SignatorController, Guid)
    }
  }
}
