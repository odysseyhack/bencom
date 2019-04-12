using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BenChainClient.Api.Models;
using BenChainClient.Api.Servicies;

namespace BenChainClient.Api.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "GET,POST,OPTIONS")]
  [System.Web.Http.RoutePrefix("api/participant")]

  public class ParticipantController : ApiController
  {
    private readonly IParticipantService _participantService;
    

    public ParticipantController(IParticipantService participantService)
    {
      _participantService = participantService;
    }

    public ParticipantController()
    {
      _participantService.Dispose();
    }

    [Route(""), HttpGet, ResponseType(typeof(IEnumerable<ParticipantModel>))]
      public async Task<IHttpActionResult> GetAll()
      {
        var participants = await _participantService.GetAll();
        return Ok(participants);
      }

  }
}
