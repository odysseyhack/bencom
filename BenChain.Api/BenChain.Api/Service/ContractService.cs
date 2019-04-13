using System;
using System.Configuration;
using System.Threading.Tasks;
using BenChain.Api.GenericContract.CQS;
using BenChain.Api.GenericContract.Service;
using BenChain.Api.Helpers;
using BenChain.Api.Models;
using BenChain.Api.Repository;
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


    /// <summary>
    /// 
    /// </summary>
    public ContractService()
    {
      var blockChainUrl = ConfigurationManager.AppSettings["BlockChainUrl"];
      _blockChainUrl = blockChainUrl;
      var mnemonic = ConfigurationManager.AppSettings["WalletMnemonic"];

      var wallet = new Wallet(mnemonic, null);
      _account = wallet.GetAccount(0);

      _contractRepository = new ContractRepository(_account, blockChainUrl);
      

      //var x = BenChainClientApi.Client.Participant.GetAllWithHttpMessagesAsync();

    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="contractBindingModel"></param>
    /// <returns></returns>
    public async Task<ResponseModel> AddContract(ContractBindingModel contractBindingModel)
    {
      var amountToSend = new HexBigInteger(1000000000000000000);

      var web3 = new Web3(_account, _blockChainUrl);

      var deployment = CreateGenericContract(new Guid("TestGuid"));
      var service = await GenericContractService.DeployContractAndGetServiceAsync(web3, deployment);
      var apporveFunction = await service.ApproveRequestAndWaitForReceiptAsync(
        new ApproveFunction
        {
          AmountToSend = amountToSend, // One ether
          FromAddress = _account.Address,
          Gas = DefaultGasAmount
        });


      var contractId = Guid.NewGuid();
      var abi =  _contractRepository.GetAbi();
      var bin = _contractRepository.GetBin();

      var responseModel = new ResponseModel(contractBindingModel.ContextId, contractId.ToString(), bin, abi);

      _ =  BenChainClientApi.Client.Context.UpdateBenChainStatusWithHttpMessagesAsync(new BenChainClient.Api.Models.BenChainContextModel
      {
        ABI = abi,
        Bytescode = bin,
        ContractId = contractId.ToString(),
        ContextId = contractBindingModel.ContextId
      });

      return responseModel;
    }

   

    /// <summary>
    /// Create contract
    /// </summary>
    /// <param name="contextId"></param>
    /// <returns></returns>
    public GenericContractDeployment CreateGenericContract(Guid contextId)
    {
      GenericContractDeployment genericContractDeployment = new GenericContractDeployment
      {
        Parent = "0x0000000000000000000000000000000000000000",
        ContextId = contextId.ToString(),
        Token = "x",
        Version = "1",
        EndDate = 1,
      };

      return genericContractDeployment;

    }
  }

}