using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using BenChain.Api.Models;
using Swashbuckle.Swagger.Annotations;

namespace BenChain.Api.Controllers
{
    [RoutePrefix("api/contract")]
    public class ContractController : ApiController
    {
    [Route(""), HttpGet, ResponseType(typeof(String))]
    [SwaggerResponse(HttpStatusCode.NotFound, Description = "No Values")]
    public OkNegotiatedContentResult<string[]> Get()
    {
      return Ok(new string[] { "value1", "value2" });
    }


    /// <summary>
    /// Add a contract to the blockchain 
    /// </summary>
    /// <param name="contextId"></param>
    /// <param name="hash1"></param>
    /// <param name="hash2"></param>
    /// <returns></returns>
    [Route("contract"), HttpGet, ResponseType(typeof(ResponseModel))]
    [SwaggerResponse(HttpStatusCode.NotFound, Description = "No Values")]
    public ResponseModel AddContract(string contextId, string hash1, string hash2)
    {
      return new ResponseModel("Dummy", "Dump", "Context ID", "ContractID");
    }

  }
}
