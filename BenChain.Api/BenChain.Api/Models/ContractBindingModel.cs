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
    public ContractBindingModel(Guid contextId, string token1, string token2)
    {
      ContextId = contextId;
      Token1 = token1;
      Token2 = token2;
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


  }
}