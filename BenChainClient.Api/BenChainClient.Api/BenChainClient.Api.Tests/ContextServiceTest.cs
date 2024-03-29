using System.Threading.Tasks;
using System.Collections.Generic;
using BenChainClient.Api.Models;
using System;
using BenChainClient.Api.Servicies;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Servicies.Tests
{
    /// <summary>This class contains parameterized unit tests for ContextService</summary>
    [TestClass]
    [PexClass(typeof(ContextService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ContextServiceTest
    {

    /// <summary>Test stub for GetAll()</summary>
    [PexMethod]
    public Task<ICollection<ContextModel>> GetAllTest([PexAssumeUnderTest]ContextService target)
    {
      Task<ICollection<ContextModel>> result = target.GetAll();
      return result;
    }

    /// <summary>Test stub for UpdateBenChainStatus(BenChainContextModel)</summary>
    [PexMethod]
    public Task<BenChainContextModel> UpdateBenChainStatusTest([PexAssumeUnderTest]ContextService target, BenChainContextModel benChainContextModel)
    {
      Task<BenChainContextModel> result = target.UpdateBenChainStatus(benChainContextModel);
      return result;
    }

    /// <summary>Test stub for CreateOrUpdate(ContextModel)</summary>
    [PexMethod]
    public Task<ContextModel> CreateOrUpdateTest([PexAssumeUnderTest]ContextService target, ContextModel contextModel)
    {
      Task<ContextModel> result = target.CreateOrUpdate(contextModel);
      return result;
    }
  }
}
