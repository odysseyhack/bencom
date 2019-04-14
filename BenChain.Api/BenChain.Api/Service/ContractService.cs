using System;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using BenChain.Api.GenericContract.CQS;
using BenChain.Api.GenericContract.Service;
using BenChain.Api.Helpers;
using BenChain.Api.Models;
using BenChain.Api.Repository;
using BenChainClient.Api.Models;
using Multiformats.Hash;
using Multiformats.Hash.Algorithms;
using Nethereum.HdWallet;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Accounts;
using Nethereum.Web3;

namespace BenChain.Api.Service
{
  /// <summary>
  /// Contract service
  /// </summary>
  public class ContractService
  {
    private readonly string _blockChainUrl;
    private const int DefaultGasAmount = 1000000;
    private IAccount _account;
    private readonly IContractRepository _contractRepository;

    public int StatusIsChanged { get; private set; }


    /// <summary>
    /// 
    /// </summary>
    public ContractService()
    {
      var blockChainUrl = ConfigurationManager.AppSettings["BlockChainUrl"];
      var mnemonic = ConfigurationManager.AppSettings["WalletMnemonic"];

      var wallet = new Wallet(mnemonic, null);
      _account = wallet.GetAccount(0);
      _blockChainUrl = blockChainUrl;

      _contractRepository = new ContractRepository(_account, blockChainUrl);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contractBindingModel"></param>
    /// <returns></returns>
    public async Task<ResponseModel> AddContract(ContractBindingModel contractBindingModel)
    {
      var amountToSend = new HexBigInteger(1000000000000000000);
      string keccak = Multihash.Encode(contractBindingModel.Token1 + contractBindingModel.Token2, HashType.KECCAK_256);
      byte[] keccak2 = Multihash.Encode(contractBindingModel.Token1 + contractBindingModel.Token2, HashType.KECCAK_256);


      var web3 = new Web3(_account, _blockChainUrl);

      var deployment = CreateGenericContract(Guid.NewGuid(), contractBindingModel);
      deployment.Gas = DefaultGasAmount;

      var transactionHash = await GenericContractService.DeployContractAsync(web3, deployment);

      //var addAttachment = await service.AddAttachmentHashRequestAndWaitForReceiptAsync(new AddAttachmentHashFunction
      //{
      //  FromAddress = _account.Address,
      //  Hash = contractBindingModel.FileChecksum,
      //  Gas = DefaultGasAmount
      //});

      var contractId = transactionHash;
      var abi = _contractRepository.GetAbi();
      var bin = _contractRepository.GetBin();

      var responseModel = new ResponseModel(contractBindingModel.ContextId, contractId, bin, abi);

      _ = BenChainClientApi.Client.Signator.BenChainUpdateWithHttpMessagesAsync(new SignatoryModel
      {
        BenChainABI = abi,
        BenChainBytescode = bin,
        BenChainContractId = contractId,
        ContextId = contractBindingModel.ContextId        
      });

      return responseModel;
    }

    public void ApproveContract(Guid contractId, string contractAddress)
    {
      var web3 = new Web3(_account, _blockChainUrl);

      var approve = new ApproveFunction()
      {
        FromAddress = _account.Address,
        Gas = DefaultGasAmount
      };

      var service = new GenericContractService(web3, contractAddress);
      _ = service.ApproveRequestAsync(approve);
    }

    /// <summary>
    /// Create contract
    /// </summary>
    /// <param name="contextId"></param>
    /// <param name="keccak">Hashed tokens</param>
    /// <returns></returns>
    public GenericContractDeployment CreateGenericContract(Guid contextId, ContractBindingModel bindingModel) {

      GenericContractDeployment genericContractDeployment = new GenericContractDeployment
      {
        Parent = "0x0000000000000000000000000000000000000000",
        ContextId = contextId.ToString(),
        Token = Encoding.ASCII.GetBytes("X"), // keccak,  
        Version = "1",
        ContextHash = bindingModel.ContextHash,
        EndDate = 9,
      };

      return genericContractDeployment;
    }
  }
}