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

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public GenericContractService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<string> ApproveRequestAsync()
        {
             return ContractHandler.SendRequestAsync<ApproveFunction>();
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<ApproveFunction>(null, cancellationToken);
        }

        public Task<string> DeclineRequestAsync(DeclineFunction declineFunction)
        {
             return ContractHandler.SendRequestAsync(declineFunction);
        }

        public Task<string> DeclineRequestAsync()
        {
             return ContractHandler.SendRequestAsync<DeclineFunction>();
        }

        public Task<TransactionReceipt> DeclineRequestAndWaitForReceiptAsync(DeclineFunction declineFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(declineFunction, cancellationToken);
        }

        public Task<TransactionReceipt> DeclineRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<DeclineFunction>(null, cancellationToken);
        }
    }
}
