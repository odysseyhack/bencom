using System.Collections.Generic;
using System.Threading.Tasks;
using BenChainClient.Api.Models;
using System;
using System.Collections;
using BenChainClient.Api.Servicies;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Servicies.Tests
{
    /// <summary>This class contains parameterized unit tests for ParticipantService</summary>
    [TestClass]
    [PexClass(typeof(ParticipantService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ParticipantServiceTest
    {

    /// <summary>Test stub for CreateOrUpdate(ParticipantModel)</summary>
    [PexMethod]
    public Task<ParticipantModel> CreateOrUpdateTest([PexAssumeUnderTest]ParticipantService target, ParticipantModel participantModel)
    {
      Task<ParticipantModel> result = target.CreateOrUpdate(participantModel);
      return result;
    }

    /// <summary>Test stub for GetAll()</summary>
    [PexMethod]
    public Task<ICollection<ParticipantModel>> GetAllTest([PexAssumeUnderTest]ParticipantService target)
    {
      Task<ICollection<ParticipantModel>> result = target.GetAll();
      return result;
    }

    /// <summary>Test stub for GetById(Guid)</summary>
    [PexMethod]
    public Task<ParticipantModel> GetByIdTest([PexAssumeUnderTest]ParticipantService target, Guid Id)
    {
      Task<ParticipantModel> result = target.GetById(Id);
      return result;
      
    }
  }
}
