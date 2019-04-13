using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BenChainClient.Api.Models;
using BenChainClient.Api.Repositories;

namespace BenChainClient.Api.Servicies
{
  public interface ISignatorServices : IDisposable
  {
    Task<ICollection<SignatoryModel>> GetAll();
    Task<SignatoryModel> CreateOrUpdate(SignatoryModel signatoryModel);
    Task<SignatoryModel> BenChainUpdate(SignatoryModel signatoryModel);

    Task<ICollection<SignatoryModel>> GetAllByParticipant(Guid participantId, int status);
    Task<ICollection<SignatoryModel>> GetAllNotOpenByParticipant(Guid participantId);
  }
}