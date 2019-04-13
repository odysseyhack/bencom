using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using BenChain.Api.Models;
using BenChain.Api.Service;
using Swashbuckle.Swagger.Annotations;

namespace BenChain.Api.Controllers
{
  [RoutePrefix("api/contract")]
  public class ContractController : ApiController
  {
    private readonly ContractService _service = new ContractService();

    [Route(""), HttpGet, ResponseType(typeof(string))]
    [SwaggerResponse(HttpStatusCode.NotFound, Description = "No Values")]
    public OkNegotiatedContentResult<string[]> Get()
    {
      return Ok(new string[] { "value1", "value2" });
    }


    /// <summary>
    /// Add a contract to the blockchain 
    /// </summary>
    /// <param name="contextId"></param>
    /// <param name="token1"></param>
    /// <param name="token2"></param>
    /// <returns></returns>
    [Route("contract"), HttpPost, ResponseType(typeof(ResponseModel))]
    [SwaggerResponse(HttpStatusCode.NotFound, Description = "No Values")]
    public async Task<IHttpActionResult> AddContract(Guid contextId, string token1, string token2)
    {
      var response = await _service.AddContract(new ContractBindingModel(contextId, token1, token2));

      return Ok(response);
    }

    

    [SwaggerResponse(HttpStatusCode.NotFound, Description = "Add Contact failed")]
    public async Task<IHttpActionResult> AddEnergyContract([FromBody] ContractBindingModel contractBindingModel)
    {
      var contract = await _service.AddContract(contractBindingModel);
      var contractid = contract.ContractId;
      if (contractid == null)
      {
        return NotFound();
      }

      return Ok(contractid);
    }


  }
}
