using Microsoft.Extensions.Logging;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Accounts;
using Nethereum.Web3;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace BenChain.Api.Repository
{
  /// <summary>
  /// Contract repo
  /// </summary>
  public class ContractRepository : IContractRepository
  {

    private HexBigInteger _defaultGas;
    private HexBigInteger _defaultValue;
    private readonly IAccount _callerAccount;
    private readonly string _abi;
    private readonly string _contractByteCode;
    private readonly string _networkUrl;
    public Web3 web3;

    /// <summary>
    /// Contract repo
    /// </summary>
    /// <param name="callerAccount"></param>
    /// <param name="networkUrl"></param>
    public ContractRepository(IAccount callerAccount, string networkUrl)
    {
      var assembly = Assembly.GetExecutingAssembly();
      _callerAccount = callerAccount;
      _networkUrl = networkUrl;
      _abi = GetStringFromStream(assembly.GetManifestResourceStream("BenChain.Api.Contracts.GenericContract.abi"));
      _contractByteCode = GetStringFromStream(assembly.GetManifestResourceStream("BenChain.Api.Contracts.GenericContract.bin"));

      web3 = new Web3(callerAccount, networkUrl);

    }    

    private static string GetStringFromStream(Stream stream)
    {
      using (var streamReader = new StreamReader(stream))
      {
        return streamReader.ReadToEnd();
      }
    }

    public Task<string> AddContract(string contextId, string token1, string token2)
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// Return ABI
    /// </summary>
    /// <returns></returns>
    public string GetAbi() => _abi;

    /// <summary>
    /// Return contract byte code
    /// </summary>
    /// <returns></returns>
    public string GetBin() => _contractByteCode;
  }
}
