using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using BenChain.Api.Models;
using Swashbuckle.Swagger.Annotations;

namespace BenChain.Api.Controllers
{
  [RoutePrefix("api/values")]
  public class ValuesController : ApiController
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
    public ResponseModel AddContract(string contextId, string hash1, string hash2)
    {
      return new ResponseModel("Dummy", "Dump", "Context ID",  "ContractID");
    }

    // GET api/values/5
    public string Get(int id)
    {
      return "value";
    }
    // POST api/values
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    public void Delete(int id)
    {
    }
  }
}
