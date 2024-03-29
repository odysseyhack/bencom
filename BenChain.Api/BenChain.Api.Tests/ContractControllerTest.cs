using System.Threading.Tasks;
using System.Web.Http;
using System;
using BenChain.Api.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChain.Api.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ContractController</summary>
    [TestClass]
    [PexClass(typeof(ContractController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ContractControllerTest
    {

    /// <summary>Test stub for AddContract(Guid, String, String, String, String)</summary>
    [PexMethod]
    public Task<IHttpActionResult> AddContractTest(
        [PexAssumeUnderTest]ContractController target,
        Guid contextId,
        string token1,
        string token2,
        string fileChecksum,
        string contextHash
    )
    {

      Task<IHttpActionResult> result = target.AddContract(contextId, token1, token2, fileChecksum, contextHash);
      Assert.IsNull(token1);
      Assert.IsNull(token2);
      Assert.IsNull(contextHash);
      Assert.IsNull(fileChecksum);
      return result;
     
    }
  }
}
