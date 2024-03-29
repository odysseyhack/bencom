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
    /// <summary>This class contains parameterized unit tests for SignatorServices</summary>
    [TestClass]
    [PexClass(typeof(SignatorServices))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SignatorServicesTest
    {

    /// <summary>Test stub for GetAll()</summary>
    [PexMethod]
    public Task<ICollection<SignatoryModel>> GetAllTest([PexAssumeUnderTest]SignatorServices target)
    {
      Task<ICollection<SignatoryModel>> result = target.GetAll();
      return result;
    }

    /// <summary>Test stub for CreateOrUpdate(SignatoryModel)</summary>
    [PexMethod]
    public Task<SignatoryModel> CreateOrUpdateTest([PexAssumeUnderTest]SignatorServices target, SignatoryModel signatoryModel)
    {
      Task<SignatoryModel> result = target.CreateOrUpdate(signatoryModel);
      return result;
    }

    /// <summary>Test stub for BenChainUpdate(SignatoryModel)</summary>
    [PexMethod]
    public Task<SignatoryModel> BenChainUpdateTest([PexAssumeUnderTest]SignatorServices target, SignatoryModel signatoryModel)
    {
      Task<SignatoryModel> result = target.BenChainUpdate(signatoryModel);
      return result;
    }
  }
}
