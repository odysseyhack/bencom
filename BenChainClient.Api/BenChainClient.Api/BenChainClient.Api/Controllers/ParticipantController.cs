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
  [RoutePrefix("api/participant")]

  public class ParticipantController : ApiController
  {
    private readonly IParticipantService _participantService;
    

    /// <summary>
    /// 
    /// </summary>
    /// <param name="participantService"></param>
    public ParticipantController(IParticipantService participantService)
    {
      _participantService = participantService;
    }

    /// <summary>
    /// 
    /// </summary>
    public ParticipantController()
    {
      _participantService.Dispose();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [Route(""), HttpGet, ResponseType(typeof(IEnumerable<ParticipantModel>))]
      public async Task<IHttpActionResult> GetAll()
      {
        var participants = await _participantService.GetAll();
        return Ok(participants);
      }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="participantModel"></param>
    /// <returns></returns>
    [Route("createdorupdate"), HttpPost, ResponseType(typeof(ParticipantModel))]
    public async Task<IHttpActionResult> CreatedOrUpdate(ParticipantModel participantModel)
    {
      var context = await _participantService.CreateOrUpdate(participantModel);
      return Ok(context);
    }
  }
}
