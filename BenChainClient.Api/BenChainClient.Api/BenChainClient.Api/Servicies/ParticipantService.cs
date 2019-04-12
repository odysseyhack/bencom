using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenChainClient.Api.Repositories;
using BenChainClient.Api.Models;

namespace BenChainClient.Api.Servicies
{
  public class ParticipantService : IParticipantService
  {
    
    private readonly ParticipantRepository _participantRepository;
    public ParticipantService()
    {
      _participantRepository = new ParticipantRepository();
    }

    public async Task<ICollection<ParticipantModel>> GetAll()
    {
      var paricipants = (await _participantRepository.GetAll().ConfigureAwait(false))
        .Select(AutoMapper.Mapper.Map<ParticipantModel>)
        .ToList();
      return paricipants;
    }

    public void Dispose()
    {
      _participantRepository.Dispose();
    }
  }
}