using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BenChainClient.Api.Models;
using BenChainClient.Api.Servicies;

namespace BenChainClient.Api.Controllers
{
   
  [EnableCors(origins: "*", headers: "*", methods: "GET,POST,OPTIONS")]
  [System.Web.Http.RoutePrefix("api/contract")]

  public class ContextController : ApiController
  {
    private readonly IContextService _contextService;


    public ContextController(IContextService contextService)
    {
      _contextService = contextService;
    }

    public ContextController()
    {
      _contextService.Dispose();
    }

    [Route(""), HttpGet, ResponseType(typeof(IEnumerable<ParticipantModel>))]
    public async Task<IHttpActionResult> GetAll()
    {
      var contexts = await _contextService.GetAll();
      return Ok(contexts);
    }

  }
}
