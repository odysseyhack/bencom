using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenChain.Api.Models
{
  /// <summary>
  /// Contract binding model
  /// </summary>
  public class ContractBindingModel
  {
    public ContractBindingModel(Guid contextId, string token1, string token2, string fileChecksum = null, string contextHash = null)
    {
      ContextId = contextId;
      Token1 = token1;
      Token2 = token2;
      FileChecksum = fileChecksum;
      ContextHash = contextHash;
    }

    /// <summary>
    /// Content ID
    /// </summary>
    public Guid ContextId { get; set; }

    /// <summary>
    /// Token 1
    /// </summary>
    public string Token1 { get; set; }

    /// <summary>
    /// Token 2
    /// </summary>
    public string Token2 { get; set; }


    /// <summary>
    /// File checksum
    /// </summary>
    public string FileChecksum { get; set; }

    /// <summary>
    /// Context HAsh
    /// </summary>
    public string ContextHash { get; set; }


  }
}