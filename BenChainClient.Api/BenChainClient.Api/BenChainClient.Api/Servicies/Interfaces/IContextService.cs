using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BenChainClient.Api.Models;

namespace BenChainClient.Api.Servicies
{
  /// <summary>
  /// 
  /// </summary>
  public interface IContextService : IDisposable
  {

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    Task<ContextModel> GetById(Guid Id);
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<ICollection<ContextModel>> GetAll();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="contextModel"></param>
    /// <returns></returns>
    Task<ContextModel> CreateOrUpdate(ContextModel contextModel);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="benChainContextModel"></param>
    /// <returns></returns>
    Task<BenChainContextModel> UpdateBenChainStatus(BenChainContextModel benChainContextModel);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ParicipantId"></param>
    /// <returns></returns>
    Task<ICollection<ContextModel>> GetAllByParticipant(Guid ParicipantId);
  }
}