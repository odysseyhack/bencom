using System;
using System.Configuration;
using System.Threading.Tasks;
using BenChain.Api.GenericContract.CQS;
using BenChain.Api.GenericContract.Service;
using BenChain.Api.Helpers;
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


    public ContractService()
    {
      var blockChainUrl = ConfigurationManager.AppSettings["BlockChainUrl"];
      _blockChainUrl = blockChainUrl;
      var mnemonic = ConfigurationManager.AppSettings["WalletMnemonic"];

      var wallet = new Wallet(mnemonic, null);

      var account = wallet.GetAccount(0);
      var contractRepo = new ContractRepository(account, blockChainUrl);

      //var x = BenChainClientApi.Client.Participant.GetAllWithHttpMessagesAsync();

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="account"></param>
    /// <param name="contextId"></param>
    /// <param name="hash1"></param>
    /// <param name="hash2"></param>
    /// <returns></returns>
    public async Task<string> AddContract(IAccount account, string contextId, string hash1, string hash2)
    {
      var amountToSend = new HexBigInteger(1000000000000000000);

      var web3 = new Web3(account, _blockChainUrl);
      var contract = CreateGenericContract(new Guid("TestGuid"));
      var service = await GenericContractService.DeployContractAndGetServiceAsync(web3, contract);
      var apporveFunction = await service.ApproveRequestAndWaitForReceiptAsync(
        new ApproveFunction
        {
          AmountToSend = amountToSend, // One ether
          FromAddress = account.Address,
          Gas = DefaultGasAmount
        });



      return apporveFunction.TransactionHash.ToString();
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