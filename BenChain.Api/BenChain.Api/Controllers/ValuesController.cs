using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
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
