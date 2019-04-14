using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenChainClient.Api.Models
{
  public class SignatoryModel
  {
    public Guid Id { get; set; }
    public Guid ParticipantId { get; set; }
    public int Status { get; set; }
    public DateTime Modified { get; set; }
    public int OrderId { get; set; }
    public Guid ContextId { get; set; }
    public string BenChainContractId { get; set; }
    public string BenChainABI { get; set; }
    public string BenChainBytescode { get; set; }
    public ContextModel ContextModel { get; set; }
  }
}