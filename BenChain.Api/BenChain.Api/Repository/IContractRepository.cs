using System.Threading.Tasks;

namespace BenChain.Api.Repository
{
  interface IContractRepository
  {
    Task<string> AddContract(string contextId, string token1, string token2);

    string GetAbi();

    string GetBin();
  }
}
