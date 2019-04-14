using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;
using BenChainClient.Api.Helpers;

namespace BenChainClient.Api.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class ContextModel
  {
    /// <summary>
    /// 
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int Ref { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DateTime Created { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DateTime Modified { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DateTime EffectiveEndDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int Status { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string Note { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string ExplanationNote { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Guid Creator { get; set; }
    public string CreatorName { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Guid Signator { get; set;}
    /// <summary>
    /// 
    /// </summary>
    public string  SignatorName { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string Token1 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string Token2 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string FileCheckSum { get; set; }
  }
}