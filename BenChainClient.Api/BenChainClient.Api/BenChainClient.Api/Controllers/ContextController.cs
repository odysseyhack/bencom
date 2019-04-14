using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BenChainClient.Api.Models;
using BenChainClient.Api.Servicies;

namespace BenChainClient.Api.Controllers
{
   
  /// <summary>
  /// 
  /// </summary>
  [EnableCors(origins: "*", headers: "*", methods: "GET,POST,OPTIONS")]
  [RoutePrefix("api/contract")]

  public class ContextController : ApiController
  {
    private readonly IContextService _contextService;


    /// <summary>
    /// 
    /// </summary>
    /// <param name="contextService"></param>
    public ContextController(IContextService contextService)
    {
      _contextService = contextService;
    }

    /// <summary>
    /// 
    /// </summary>
    public ContextController()
    {
      _contextService.Dispose();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [Route("byid"), HttpGet, ResponseType(typeof(ContextModel))]
    public async Task<IHttpActionResult> GetById(Guid Id)
    {
      var context = await _contextService.GetById(Id);
      return Ok(context);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [Route(""), HttpGet, ResponseType(typeof(IEnumerable<ContextModel>))]
    public async Task<IHttpActionResult> GetAll()
    {
      var contexts = await _contextService.GetAll();
      return Ok(contexts);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="participant"></param>
    /// <returns></returns>
    [Route("participant"), HttpGet, ResponseType(typeof(IEnumerable<ContextModel>))]
    public async Task<IHttpActionResult> GetAllByParticipant(Guid participant)
    {
      var contexts = await _contextService.GetAllByParticipant(participant);
      return Ok(contexts);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contextModel"></param>
    /// <returns></returns>
    [Route("createdorupdate"), HttpPost, ResponseType(typeof(ContextModel))]
    public async Task<IHttpActionResult> CreatedOrUpdate(ContextModel contextModel)
    {
      var contexts = await _contextService.CreateOrUpdate(contextModel);
      return Ok(contexts);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="benchainContextModel"></param>
    /// <returns></returns>
    [Route("updateBenChainStatus"), HttpPost, ResponseType(typeof(ContextModel))]
    public async Task<IHttpActionResult> UpdateBenChainStatus(BenChainContextModel benchainContextModel)
    {
      var contexts = await _contextService.UpdateBenChainStatus(benchainContextModel);
      return Ok(contexts);
    }

  }
}
