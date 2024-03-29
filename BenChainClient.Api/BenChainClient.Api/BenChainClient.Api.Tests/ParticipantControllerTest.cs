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
    /// <summary>This class contains parameterized unit tests for ParticipantController</summary>
    [TestClass]
    [PexClass(typeof(ParticipantController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ParticipantControllerTest
    {

    /// <summary>Test stub for GetAll()</summary>
    [PexMethod]
    public Task<IHttpActionResult> GetAllTest([PexAssumeUnderTest]ParticipantController target)
    {
      Task<IHttpActionResult> result = target.GetAll();
      return result;
    }

    /// <summary>Test stub for CreatedOrUpdate(ParticipantModel)</summary>
    [PexMethod]
    public Task<IHttpActionResult> CreatedOrUpdateTest([PexAssumeUnderTest]ParticipantController target, ParticipantModel participantModel)
    {
      Task<IHttpActionResult> result = target.CreatedOrUpdate(participantModel);
      return result;
    }
  }
}
