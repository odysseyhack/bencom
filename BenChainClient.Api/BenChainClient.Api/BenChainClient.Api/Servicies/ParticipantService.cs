using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenChainClient.Api.DbEntities;
using BenChainClient.Api.Repositories;
using BenChainClient.Api.Models;

namespace BenChainClient.Api.Servicies
{
  /// <summary>
  /// 
  /// </summary>
  public class ParticipantService : IParticipantService
  {
    
    private readonly ParticipantRepository _participantRepository;
    /// <summary>
    /// 
    /// </summary>
    public ParticipantService()
    {
      _participantRepository = new ParticipantRepository();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<ICollection<ParticipantModel>> GetAll()
    {
      var paricipants = (await _participantRepository.GetAll().ConfigureAwait(false))
        .Select(AutoMapper.Mapper.Map<ParticipantModel>)
        .ToList();
      return paricipants;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    public async Task<ParticipantModel> GetById(Guid Id)
    {
      var paricipants = (await _participantRepository.GetAllWhere(s=>s.Id == Id).ConfigureAwait(false))
        .Select(AutoMapper.Mapper.Map<ParticipantModel>).FirstOrDefault();
      return paricipants;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="participantModel"></param>
    /// <returns></returns>
    public async Task<ParticipantModel> CreateOrUpdate(ParticipantModel participantModel)
    {
      if (participantModel.Id==Guid.Empty)
      {
        participantModel.Id = Guid.NewGuid();
        participantModel.HashId = Helpers.Hash256Tool.Sha256HashString(participantModel.Id.ToString());
      }
      var participantDb = await _participantRepository.FindBy(s => s.Id == participantModel.Id).ConfigureAwait(false);

      if (participantDb == null)
      {
        var participant = AutoMapper.Mapper.Map<Participant>(participantModel);
        _participantRepository.Create(participant);
        _participantRepository.Save(true, false, participantModel.Id);
      }
      else
      {
        AutoMapper.Mapper.Map(participantModel, participantDb);
        _participantRepository.Update(participantDb);
        _participantRepository.Save(true, false, participantModel.Id);
      }

      return participantModel;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
      _participantRepository.Dispose();
    }
  }
}