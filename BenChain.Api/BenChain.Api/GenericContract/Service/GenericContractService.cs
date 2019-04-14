using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using BenChain.Api.GenericContract.CQS;

namespace BenChain.Api.GenericContract.Service
{
  public partial class GenericContractService
  {
    public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, GenericContractDeployment genericContractDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
      return web3.Eth.GetContractDeploymentHandler<GenericContractDeployment>().SendRequestAndWaitForReceiptAsync(genericContractDeployment, cancellationTokenSource);
    }

    public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, GenericContractDeployment genericContractDeployment)
    {
      return web3.Eth.GetContractDeploymentHandler<GenericContractDeployment>().SendRequestAsync(genericContractDeployment);
    }

    public static async Task<GenericContractService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, GenericContractDeployment genericContractDeployment, CancellationTokenSource cancellationTokenSource = null)
    {
      var receipt = await DeployContractAndWaitForReceiptAsync(web3, genericContractDeployment, cancellationTokenSource);
      return new GenericContractService(web3, receipt.ContractAddress);
    }

    protected Nethereum.Web3.Web3 Web3 { get; }

    public ContractHandler ContractHandler { get; }

    public GenericContractService(Nethereum.Web3.Web3 web3, string contractAddress)
    {
      Web3 = web3;
      ContractHandler = web3.Eth.GetContractHandler(contractAddress);
    }

    public Task<string> GetCreatorQueryAsync(GetCreatorFunction getCreatorFunction, BlockParameter blockParameter = null)
    {
      return ContractHandler.QueryAsync<GetCreatorFunction, string>(getCreatorFunction, blockParameter);
    }


    public Task<string> GetCreatorQueryAsync(BlockParameter blockParameter = null)
    {
      return ContractHandler.QueryAsync<GetCreatorFunction, string>(null, blockParameter);
    }

    public Task<byte[]> GetTokenQueryAsync(GetTokenFunction getTokenFunction, BlockParameter blockParameter = null)
    {
      return ContractHandler.QueryAsync<GetTokenFunction, byte[]>(getTokenFunction, blockParameter);
    }


    public Task<byte[]> GetTokenQueryAsync(BlockParameter blockParameter = null)
    {
      return ContractHandler.QueryAsync<GetTokenFunction, byte[]>(null, blockParameter);
    }

    public Task<string> AddAttachmentHashRequestAsync(AddAttachmentHashFunction addAttachmentHashFunction)
    {
      return ContractHandler.SendRequestAsync(addAttachmentHashFunction);
    }

    public Task<TransactionReceipt> AddAttachmentHashRequestAndWaitForReceiptAsync(AddAttachmentHashFunction addAttachmentHashFunction, CancellationTokenSource cancellationToken = null)
    {
      return ContractHandler.SendRequestAndWaitForReceiptAsync(addAttachmentHashFunction, cancellationToken);
    }

    public Task<string> AddAttachmentHashRequestAsync(string hash)
    {
      var addAttachmentHashFunction = new AddAttachmentHashFunction();
      addAttachmentHashFunction.Hash = hash;

      return ContractHandler.SendRequestAsync(addAttachmentHashFunction);
    }

    public Task<TransactionReceipt> AddAttachmentHashRequestAndWaitForReceiptAsync(string hash, CancellationTokenSource cancellationToken = null)
    {
      var addAttachmentHashFunction = new AddAttachmentHashFunction();
      addAttachmentHashFunction.Hash = hash;

      return ContractHandler.SendRequestAndWaitForReceiptAsync(addAttachmentHashFunction, cancellationToken);
    }

    public Task<BigInteger> GetStatusQueryAsync(GetStatusFunction getStatusFunction, BlockParameter blockParameter = null)
    {
      return ContractHandler.QueryAsync<GetStatusFunction, BigInteger>(getStatusFunction, blockParameter);
    }


    public Task<BigInteger> GetStatusQueryAsync(BlockParameter blockParameter = null)
    {
      return ContractHandler.QueryAsync<GetStatusFunction, BigInteger>(null, blockParameter);
    }

    public Task<string> DeclineRequestAsync(DeclineFunction declineFunction)
    {
      return ContractHandler.SendRequestAsync(declineFunction);
    }

    public Task<TransactionReceipt> DeclineRequestAndWaitForReceiptAsync(DeclineFunction declineFunction, CancellationTokenSource cancellationToken = null)
    {
      return ContractHandler.SendRequestAndWaitForReceiptAsync(declineFunction, cancellationToken);
    }

    public Task<string> DeclineRequestAsync(string token1, string token2)
    {
      var declineFunction = new DeclineFunction();
      declineFunction.Token1 = token1;
      declineFunction.Token2 = token2;

      return ContractHandler.SendRequestAsync(declineFunction);
    }

    public Task<TransactionReceipt> DeclineRequestAndWaitForReceiptAsync(string token1, string token2, CancellationTokenSource cancellationToken = null)
    {
      var declineFunction = new DeclineFunction();
      declineFunction.Token1 = token1;
      declineFunction.Token2 = token2;

      return ContractHandler.SendRequestAndWaitForReceiptAsync(declineFunction, cancellationToken);
    }

    public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
    {
      return ContractHandler.SendRequestAsync(approveFunction);
    }

    public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
    {
      return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
    }

    public Task<string> ApproveRequestAsync(string token1, string token2)
    {
      var approveFunction = new ApproveFunction();
      approveFunction.Token1 = token1;
      approveFunction.Token2 = token2;

      return ContractHandler.SendRequestAsync(approveFunction);
    }

    public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string token1, string token2, CancellationTokenSource cancellationToken = null)
    {
      var approveFunction = new ApproveFunction();
      approveFunction.Token1 = token1;
      approveFunction.Token2 = token2;

      return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
    }

    public Task<BigInteger> GetCreateDateQueryAsync(GetCreateDateFunction getCreateDateFunction, BlockParameter blockParameter = null)
    {
      return ContractHandler.QueryAsync<GetCreateDateFunction, BigInteger>(getCreateDateFunction, blockParameter);
    }


    public Task<BigInteger> GetCreateDateQueryAsync(BlockParameter blockParameter = null)
    {
      return ContractHandler.QueryAsync<GetCreateDateFunction, BigInteger>(null, blockParameter);
    }
  }
}
