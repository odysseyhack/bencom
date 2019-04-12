using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BenChainClient.Api.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "GET,POST,OPTIONS")]
  [RoutePrefix("api/values")]

  public class ValuesController : ApiController
  {
    [HttpGet, Route("")]
    /// <summary>
    /// test
    /// </summary>
    /// <returns></returns>
    /// 
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

   
  }
}
