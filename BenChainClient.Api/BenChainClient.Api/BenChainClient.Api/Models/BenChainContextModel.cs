using System;

namespace BenChainClient.Api.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class BenChainContextModel
  {
    /// <summary>
    /// 
    /// </summary>
    public Guid? ContextId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string ContractId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string ABI { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string Bytescode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int Status { get; set; }
  }
}