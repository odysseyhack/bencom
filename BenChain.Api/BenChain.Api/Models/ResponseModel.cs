namespace BenChain.Api.Models
{
  public class ResponseModel
  {
    /// <summary>
    /// Response model
    /// </summary>
    /// <param name="contextId"></param>
    /// <param name="contractId"></param>
    /// <param name="abi"></param>
    /// <param name="bin"></param>
    public ResponseModel(string contextId, string contractId, string abi, string bin)
    {
      ContextId = contextId;
      ContractId = contractId;
      Abi = abi;
      Bin = bin;
    }

    /// <summary>
    /// Context ID
    /// </summary>
    public string ContextId { get; set; }


    /// <summary>
    ///  Returns the contract ID
    /// </summary>
    public string ContractId { get; set; }

    /// <summary>
    /// ABI file for reverse the SmartContract
    /// </summary>
    public string Abi { get; set; }


    /// <summary>
    /// Bin file is needed for the approving the contract
    /// </summary>
    public string  Bin { get; set; }

  }
}