﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BenChainClient.Api.Models;

namespace BenChainClient.Api.Servicies
{
  public interface IParticipantService : IDisposable
  {
    Task<ICollection<ParticipantModel>> GetAll();
  }
}