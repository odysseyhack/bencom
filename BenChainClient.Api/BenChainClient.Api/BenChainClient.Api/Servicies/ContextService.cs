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
  public class ContextService : IContextService
  {
    private readonly ContextRepository _contextRepository;
    private readonly SignatorServices _signatorServices;
    private readonly SignatorRepository _signatorRepository;

    /// <summary>
    /// 
    /// </summary>
    public ContextService()
    {
      _contextRepository = new ContextRepository();
      _signatorRepository = new SignatorRepository();
      _signatorServices = new SignatorServices();
    }

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <returns></returns>
    public async Task<ICollection<ContextModel>> GetAll()
    {
      var contexts = (await _contextRepository.GetAll().ConfigureAwait(false))
        .Select(AutoMapper.Mapper.Map<ContextModel>)
        .ToList();
      return contexts;
    }

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <param name="contextModel"></param>
    /// <returns></returns>
    public async Task<ContextModel> CreateOrUpdate(ContextModel contextModel)
    {
      if (contextModel.Id == Guid.Empty)
      {
        contextModel.Id = Guid.NewGuid();
        contextModel.Token1 =
          Helpers.Hash256Tool.Sha256HashString(contextModel.Id + contextModel.Creator.ToString() + "1");
        contextModel.Token2 =
          Helpers.Hash256Tool.Sha256HashString(contextModel.Id + contextModel.Creator.ToString() + "2");
        contextModel.Created = DateTime.Now;
        contextModel.Modified = DateTime.Now;
      }

      var contextDb = await _contextRepository.FindBy(s => s.Id == contextModel.Id).ConfigureAwait(false);

      if (contextDb == null)
      {
        var context = AutoMapper.Mapper.Map<Context>(contextModel);
        _contextRepository.Create(context);
        _contextRepository.Save(false, false, contextModel.Id);
      }
      else
      {
        AutoMapper.Mapper.Map(contextModel, contextDb);
        _contextRepository.Update(contextDb);
        _contextRepository.Save(false, false, contextModel.Id);
      }

      var contractid = Guid.NewGuid().ToString();

      //var contractid = BenChainApi.Client.Contract.GetEnergyContractAsync(contractId);
      //First Signator
      var signator = new SignatoryModel
      {
        Id = Guid.NewGuid(),
        ParticipantId = contextModel.Signator,
        ContextId = contextModel.Id,
        BenChainContractId = contractid,
        Status = 0,
        Modified = DateTime.Now,
        OrderId = 0,
        BenChainABI = "",
        BenChainBytescode = "",
      };
      await _signatorServices.CreateOrUpdate(signator);


      switch (contextModel.Ref)
      {
        case 0:
          //Case 1
          //Second Signator
          signator = new SignatoryModel
          {
            Id = Guid.NewGuid(),
            ParticipantId = Guid.NewGuid(),
            ContextId = contextModel.Id,
            Status = 0,
            Modified = DateTime.Now,
            OrderId = 1,
            BenChainABI = "",
            BenChainBytescode = "",
            BenChainContractId = ""
          };
          await _signatorServices.CreateOrUpdate(signator);

          break;
        case 1:
          //Case 2
          //Second Signator
          break;
        case 2:
          //Case 3
          //Second Signator
          break;
      }

      return contextModel;
    }

    


    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <param name="benChainContextModel"></param>
    /// <returns></returns>
    public async Task<BenChainContextModel> UpdateBenChainStatus(BenChainContextModel benChainContextModel)
    {
     //First to 
      var signatorDb = (await _signatorRepository.GetAllWhere(c => c.Id == benChainContextModel.ContextId && benChainContextModel.Status == 0 ).ConfigureAwait(false)).OrderBy(c=>c.OrderId).FirstOrDefault();
      if (signatorDb == null) return benChainContextModel;

      signatorDb.BenChainABI = benChainContextModel.ABI;
      signatorDb.BenChainBytescode = benChainContextModel.Bytescode;
      signatorDb.BenChainContractId = benChainContextModel.ContractId;
      _signatorRepository.Update(signatorDb);
      _signatorRepository.Save(false, false, signatorDb.Id);

      return benChainContextModel;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
      _contextRepository.Dispose();
    }
  }
}