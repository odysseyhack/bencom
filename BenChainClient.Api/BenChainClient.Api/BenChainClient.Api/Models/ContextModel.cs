using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BenChainClient.Api.Models
{
  public class ContextModel
  {
    public Guid Creator { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime EffectiveEndDate { get; set; }
    public int Status { get; set; }
  }
}