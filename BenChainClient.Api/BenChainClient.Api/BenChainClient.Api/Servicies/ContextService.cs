using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BenChainClient.Api.Models;
using BenChainClient.Api.Repositories;

namespace BenChainClient.Api.Servicies
{
  public class ContextService : IContextService
  {
    private readonly ContextRepository _contextRepository;
    public ContextService()
    {
      _contextRepository = new ContextRepository();
    }

    public async Task<ICollection<ContextModel>> GetAll()
    {
      var contexts = (await _contextRepository.GetAll().ConfigureAwait(false))
        .Select(AutoMapper.Mapper.Map<ContextModel>)
        .ToList();
      return contexts;
    }

    public void Dispose()
    {
      _contextRepository.Dispose();
    }
  }
}