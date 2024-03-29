using System.Numerics;
using System.Threading;
using BenChain.Api.GenericContract.CQS;
using Nethereum.Web3;
using System.Threading.Tasks;
using Nethereum.RPC.Eth.DTOs;
using System;
using BenChain.Api.GenericContract.Service;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChain.Api.GenericContract.Service.Tests
{
  /// <summary>This class contains parameterized unit tests for GenericContractService</summary>
  [TestClass]
  [PexClass(typeof(GenericContractService))]
  [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
  [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
  public partial class GenericContractServiceTest
  {



    /// <summary>Test stub for DeployContractAndWaitForReceiptAsync(Web3, GenericContractDeployment, CancellationTokenSource)</summary>
    [PexMethod]
    public Task<TransactionReceipt> DeployContractAndWaitForReceiptAsyncTest(
        global::Nethereum.Web3.Web3 web3,
        GenericContractDeployment genericContractDeployment,
        CancellationTokenSource cancellationTokenSource
    )
    {
      Task<TransactionReceipt> result = GenericContractService.DeployContractAndWaitForReceiptAsync
                                            (web3, genericContractDeployment, cancellationTokenSource);
      return result;

    }

    /// <summary>Test stub for DeployContractAsync(Web3, GenericContractDeployment)</summary>
    [PexMethod]
    public Task<string> DeployContractAsyncTest(global::Nethereum.Web3.Web3 web3, GenericContractDeployment genericContractDeployment)
    {
      Task<string> result = GenericContractService.DeployContractAsync(web3, genericContractDeployment);
      return result;

    }

    /// <summary>Test stub for DeployContractAndGetServiceAsync(Web3, GenericContractDeployment, CancellationTokenSource)</summary>
    [PexMethod]
    public Task<GenericContractService> DeployContractAndGetServiceAsyncTest(
        global::Nethereum.Web3.Web3 web3,
        GenericContractDeployment genericContractDeployment,
        CancellationTokenSource cancellationTokenSource
    )
    {
      Task<GenericContractService> result = GenericContractService.DeployContractAndGetServiceAsync
                                                (web3, genericContractDeployment, cancellationTokenSource);
     
      Assert.IsNotNull(result);
      return result;

    }

    /// <summary>Test stub for .ctor(Web3, String)</summary>
    [PexMethod]
    public GenericContractService ConstructorTest(global::Nethereum.Web3.Web3 web3, string contractAddress)
    {
      GenericContractService target = new GenericContractService(web3, contractAddress);
      Assert.IsNotNull(target);
      return target;
      
    }

    /// <summary>Test stub for GetCreatorQueryAsync(GetCreatorFunction, BlockParameter)</summary>
    [PexMethod]
    public Task<string> GetCreatorQueryAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        GetCreatorFunction getCreatorFunction,
        BlockParameter blockParameter
    )
    {
      Task<string> result = target.GetCreatorQueryAsync(getCreatorFunction, blockParameter);
      Assert.IsNotNull(result);
      return result;

    }

    /// <summary>Test stub for GetCreatorQueryAsync(BlockParameter)</summary>
    [PexMethod]
    public Task<string> GetCreatorQueryAsyncTest([PexAssumeUnderTest]GenericContractService target, BlockParameter blockParameter)
    {
      Task<string> result = target.GetCreatorQueryAsync(blockParameter);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for GetTokenQueryAsync(GetTokenFunction, BlockParameter)</summary>
    [PexMethod]
    public Task<byte[]> GetTokenQueryAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        GetTokenFunction getTokenFunction,
        BlockParameter blockParameter
    )
    {
      Task<byte[]> result = target.GetTokenQueryAsync(getTokenFunction, blockParameter);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for GetTokenQueryAsync(BlockParameter)</summary>
    [PexMethod]
    public Task<byte[]> GetTokenQueryAsyncTest([PexAssumeUnderTest]GenericContractService target, BlockParameter blockParameter)
    {
      Task<byte[]> result = target.GetTokenQueryAsync(blockParameter);
      Assert.IsNotNull(result);
      return result;
     
    }

    /// <summary>Test stub for AddAttachmentHashRequestAsync(AddAttachmentHashFunction)</summary>
    [PexMethod]
    public Task<string> AddAttachmentHashRequestAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        AddAttachmentHashFunction addAttachmentHashFunction
    )
    {
      Task<string> result = target.AddAttachmentHashRequestAsync(addAttachmentHashFunction);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for AddAttachmentHashRequestAndWaitForReceiptAsync(AddAttachmentHashFunction, CancellationTokenSource)</summary>
    [PexMethod]
    public Task<TransactionReceipt> AddAttachmentHashRequestAndWaitForReceiptAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        AddAttachmentHashFunction addAttachmentHashFunction,
        CancellationTokenSource cancellationToken
    )
    {
      Task<TransactionReceipt> result = target.AddAttachmentHashRequestAndWaitForReceiptAsync
                                            (addAttachmentHashFunction, cancellationToken);
      Assert.IsNotNull(result);
      return result;

    }

    /// <summary>Test stub for AddAttachmentHashRequestAsync(String)</summary>
    [PexMethod]
    public Task<string> AddAttachmentHashRequestAsyncTest([PexAssumeUnderTest]GenericContractService target, string hash)
    {
      Task<string> result = target.AddAttachmentHashRequestAsync(hash);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for AddAttachmentHashRequestAndWaitForReceiptAsync(String, CancellationTokenSource)</summary>
    [PexMethod]
    public Task<TransactionReceipt> AddAttachmentHashRequestAndWaitForReceiptAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        string hash,
        CancellationTokenSource cancellationToken
    )
    {
      Task<TransactionReceipt> result
         = target.AddAttachmentHashRequestAndWaitForReceiptAsync(hash, cancellationToken);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for GetStatusQueryAsync(GetStatusFunction, BlockParameter)</summary>
    [PexMethod]
    public Task<BigInteger> GetStatusQueryAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        GetStatusFunction getStatusFunction,
        BlockParameter blockParameter
    )
    {
      Task<BigInteger> result = target.GetStatusQueryAsync(getStatusFunction, blockParameter);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for GetStatusQueryAsync(BlockParameter)</summary>
    [PexMethod]
    public Task<BigInteger> GetStatusQueryAsyncTest([PexAssumeUnderTest]GenericContractService target, BlockParameter blockParameter)
    {
      Task<BigInteger> result = target.GetStatusQueryAsync(blockParameter);
      Assert.IsNotNull(result);
      return result;

    }

    /// <summary>Test stub for DeclineRequestAsync(DeclineFunction)</summary>
    [PexMethod]
    public Task<string> DeclineRequestAsyncTest([PexAssumeUnderTest]GenericContractService target, DeclineFunction declineFunction)
    {
      Task<string> result = target.DeclineRequestAsync(declineFunction);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for DeclineRequestAndWaitForReceiptAsync(DeclineFunction, CancellationTokenSource)</summary>
    [PexMethod]
    public Task<TransactionReceipt> DeclineRequestAndWaitForReceiptAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        DeclineFunction declineFunction,
        CancellationTokenSource cancellationToken
    )
    {
      Task<TransactionReceipt> result
         = target.DeclineRequestAndWaitForReceiptAsync(declineFunction, cancellationToken);
      Assert.IsNotNull(result);
      return result;

    }
    
    /// <summary>Test stub for ApproveRequestAsync(ApproveFunction)</summary>
    [PexMethod]
    public Task<string> ApproveRequestAsyncTest([PexAssumeUnderTest]GenericContractService target, ApproveFunction approveFunction)
    {
      Task<string> result = target.ApproveRequestAsync(approveFunction);
      Assert.IsNotNull(result);
      return result;
     
    }

    /// <summary>Test stub for ApproveRequestAndWaitForReceiptAsync(ApproveFunction, CancellationTokenSource)</summary>
    [PexMethod]
    public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        ApproveFunction approveFunction,
        CancellationTokenSource cancellationToken
    )
    {
      Task<TransactionReceipt> result
         = target.ApproveRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for GetCreateDateQueryAsync(GetCreateDateFunction, BlockParameter)</summary>
    [PexMethod]
    public Task<BigInteger> GetCreateDateQueryAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        GetCreateDateFunction getCreateDateFunction,
        BlockParameter blockParameter
    )
    {
      Task<BigInteger> result = target.GetCreateDateQueryAsync(getCreateDateFunction, blockParameter);
      Assert.IsNotNull(result);
      return result;
      
    }

    /// <summary>Test stub for GetCreateDateQueryAsync(BlockParameter)</summary>
    [PexMethod]
    public Task<BigInteger> GetCreateDateQueryAsyncTest([PexAssumeUnderTest]GenericContractService target, BlockParameter blockParameter)
    {
      Task<BigInteger> result = target.GetCreateDateQueryAsync(blockParameter);
      Assert.IsNotNull(result);
      return result;
    }
  }
}
