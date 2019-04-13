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
      return result;
      
    }

    /// <summary>Test stub for ApproveRequestAsync(ApproveFunction)</summary>
    [PexMethod]
    public Task<string> ApproveRequestAsyncTest([PexAssumeUnderTest]GenericContractService target, ApproveFunction approveFunction)
    {
      Task<string> result = target.ApproveRequestAsync(approveFunction);
      return result;
      
    }

    /// <summary>Test stub for ApproveRequestAsync()</summary>
    [PexMethod]
    public Task<string> ApproveRequestAsyncTest([PexAssumeUnderTest]GenericContractService target)
    {
      Task<string> result = target.ApproveRequestAsync();
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
      return result;
      
    }

    /// <summary>Test stub for ApproveRequestAndWaitForReceiptAsync(CancellationTokenSource)</summary>
    [PexMethod]
    public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        CancellationTokenSource cancellationToken
    )
    {
      Task<TransactionReceipt> result = target.ApproveRequestAndWaitForReceiptAsync(cancellationToken);
      return result;
      
    }

    /// <summary>Test stub for DeclineRequestAsync(DeclineFunction)</summary>
    [PexMethod]
    public Task<string> DeclineRequestAsyncTest([PexAssumeUnderTest]GenericContractService target, DeclineFunction declineFunction)
    {
      Task<string> result = target.DeclineRequestAsync(declineFunction);
      return result;
      
    }

    /// <summary>Test stub for DeclineRequestAsync()</summary>
    [PexMethod]
    public Task<string> DeclineRequestAsyncTest([PexAssumeUnderTest]GenericContractService target)
    {
      Task<string> result = target.DeclineRequestAsync();
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
      return result;
      
    }

    /// <summary>Test stub for DeclineRequestAndWaitForReceiptAsync(CancellationTokenSource)</summary>
    [PexMethod]
    public Task<TransactionReceipt> DeclineRequestAndWaitForReceiptAsyncTest(
        [PexAssumeUnderTest]GenericContractService target,
        CancellationTokenSource cancellationToken
    )
    {
      Task<TransactionReceipt> result = target.DeclineRequestAndWaitForReceiptAsync(cancellationToken);
      return result;
      
    }
  }
}
