using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BenChainClient.Api.Models;
using BenChainClient.Api.Servicies;

namespace BenChainClient.Api.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "GET,POST,OPTIONS")]
  [System.Web.Http.RoutePrefix("api/signator")]

  public class SignatorController : ApiController
  {
    private readonly ISignatorServices _signatorServices;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="signatorServices"></param>
    public SignatorController(ISignatorServices signatorServices)
    {
      _signatorServices = signatorServices;
    }

    /// <summary>
    /// 
    /// </summary>
    public SignatorController()
    {
      _signatorServices.Dispose();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [Route(""), HttpGet, ResponseType(typeof(IEnumerable<SignatoryModel>))]
    public async Task<IHttpActionResult> GetAll()
    {
      var signators = await _signatorServices.GetAll();
      return Ok(signators);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="participantId"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    [Route("bystatus"), HttpGet, ResponseType(typeof(IEnumerable<SignatoryModel>))]
    public async Task<IHttpActionResult> GetAllByParticipant(Guid participantId, int status)
    {
      var signators = await _signatorServices.GetAllByParticipant(participantId, status);
      return Ok(signators);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="participantId"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    [Route("bystatusnotopen"), HttpGet, ResponseType(typeof(IEnumerable<SignatoryModel>))]
    public async Task<IHttpActionResult> GetAllNotOpenByParticipant(Guid participantId)
    {
      var signators = await _signatorServices.GetAllNotOpenByParticipant(participantId);
      return Ok(signators);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="participantModel"></param>
    /// <returns></returns>
    [Route("createdorupdate"), HttpPost, ResponseType(typeof(SignatoryModel))]
    public async Task<IHttpActionResult> CreatedOrUpdate(SignatoryModel participantModel)
    {
      var context = await _signatorServices.CreateOrUpdate(participantModel);
      return Ok(context);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="participantModel"></param>
    /// <returns></returns>
    [Route("benchainupdate"), HttpPost, ResponseType(typeof(SignatoryModel))]
    public async Task<IHttpActionResult> BenChainUpdate(SignatoryModel signatoryModel)
    {
      var context = await _signatorServices.BenChainUpdate(signatoryModel);
      return Ok(context);
    }
  }
}