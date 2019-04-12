using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenChainClient.Api.Models
{
  public class ParticipantModel
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string SignatorLevel { get; set; }
    public string ParticipantHash { get; set; }

  }
}