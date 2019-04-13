using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenChainClient.Api.DbEntities;
using BenChainClient.Api.Models;
using BenChainClient.Api.Repositories;


namespace BenChainClient.Api.Servicies
{
  /// <summary>
  /// 
  /// </summary>
  public class SignatorServices : ISignatorServices
  {
    
    private readonly SignatorRepository _signatorRepository;

    /// <summary>
    /// 
    /// </summary>
    public SignatorServices()
    {
      _signatorRepository = new SignatorRepository();
    }

    public async Task<ICollection<SignatoryModel>> GetAll()
    {
      var signators = (await _signatorRepository.GetAll().ConfigureAwait(false))
        .Select(AutoMapper.Mapper.Map<SignatoryModel>)
        .ToList();
      return signators;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="participantId"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    public async Task<ICollection<SignatoryModel>> GetAllByParticipant(Guid participantId, int status)
    {
      var signators = (await _signatorRepository.GetAllWhere(s => s.ParticipantId == participantId && s.Status == status).ConfigureAwait(false))
        .Select(AutoMapper.Mapper.Map<SignatoryModel>)
        .ToList();
      return signators;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="signatoryModel"></param>
    /// <returns></returns>
    public async Task<SignatoryModel> CreateOrUpdate(SignatoryModel signatoryModel)
    {
      if (signatoryModel.Id == Guid.Empty)
      {
        signatoryModel.Id = Guid.NewGuid();
      }
      var signatoryDb = await _signatorRepository.FindBy(s => s.Id == signatoryModel.Id).ConfigureAwait(false);

      if (signatoryDb == null)
      {
        var signatory = AutoMapper.Mapper.Map<Signatory>(signatoryModel);
        _signatorRepository.Create(signatory);
        _signatorRepository.Save(true, false, signatoryModel.Id);
      }
      else
      {
        AutoMapper.Mapper.Map(signatoryModel, signatoryDb);
        _signatorRepository.Update(signatoryDb);
        _signatorRepository.Save(true, false, signatoryModel.Id);
      }

      return signatoryModel;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="signatoryModel"></param>
    /// <returns></returns>
    public async Task<SignatoryModel> BenChainUpdate(SignatoryModel signatoryModel)
    {
      if (signatoryModel.ContextId != Guid.Empty)
      {
        var signatoryDb = await _signatorRepository.FindBy(s => s.ContextId == signatoryModel.ContextId).ConfigureAwait(false);
        if (signatoryDb != null)
        {
          signatoryDb.BenChainContractId = signatoryModel.BenChainContractId;
          signatoryDb.BenChainABI = signatoryModel.BenChainABI;
          signatoryDb.BenChainBytescode = signatoryModel.BenChainBytescode;

          AutoMapper.Mapper.Map(signatoryModel, signatoryDb);
          _signatorRepository.Update(signatoryDb);
          _signatorRepository.Save(true, false, signatoryModel.Id);
        }
      }

      return signatoryModel;
    }


    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
      _signatorRepository.Dispose();
    }
  }
}