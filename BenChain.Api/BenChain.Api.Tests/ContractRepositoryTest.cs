using System.Threading.Tasks;
// <copyright file="ContractRepositoryTest.cs">Copyright ©  2019</copyright>
using System;
using BenChain.Api.Repository;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChain.Api.Repository.Tests
{
    /// <summary>This class contains parameterized unit tests for ContractRepository</summary>
    [PexClass(typeof(ContractRepository))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ContractRepositoryTest
    {

    /// <summary>Test stub for AddContract(String, String, String)</summary>
    [PexMethod]
    public Task<string> AddContractTest(
        [PexAssumeUnderTest]ContractRepository target,
        string contextId,
        string token1,
        string token2
    )
    {
      Task<string> result = target.AddContract(contextId, token1, token2);
      return result;
    }
  }
}
