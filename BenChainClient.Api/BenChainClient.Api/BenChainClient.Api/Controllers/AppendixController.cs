using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BenChainClient.Api.Models;
using BenChainClient.Api.Servicies;
using Swashbuckle.Swagger.Annotations;
using BenChainClient.Api.Helpers;

namespace BenChainClient.Api.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "GET,POST,OPTIONS")]
  [System.Web.Http.RoutePrefix("api/contract")]

  public class AppendixController : ApiController
  {
    private readonly IContextService _contextService;


    public AppendixController(IContextService contextService)
    {
      _contextService = contextService;
    }

    public AppendixController()
    {
      _contextService.Dispose();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [Route("uploadfiles"), HttpPost, ResponseType(typeof(String))]
    [SwaggerResponse(HttpStatusCode.NotFound, Description = "No file uploaded")]
    public async Task<IHttpActionResult> UploadFilesByPost()
    {
      var httpContext = HttpContext.Current;
      if (httpContext.Request.Files.Count > 0)
      {
        for (int i = 0; i < httpContext.Request.Files.Count; i++)
        {
          HttpPostedFile httpPostedFile = httpContext.Request.Files[i];
          if (httpPostedFile != null)
          {
            var fileSavePath =
              Path.Combine(HostingEnvironment.MapPath(ConfigurationManager.AppSettings["fileUploadFolder"]),
                httpPostedFile.FileName);

            var CheckSum = Helpers.Hash256Tool.Sha256File(fileSavePath);

            httpPostedFile.SaveAs(fileSavePath);
          }
        }

        return Ok();
      }

      return NotFound();

    }
  }
}