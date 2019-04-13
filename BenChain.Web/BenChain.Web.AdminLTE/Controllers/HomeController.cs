using BenChain.Web.AdminLTE.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenChain.Web.AdminLTE.Controllers {
  public class HomeController : Controller {

    [HttpGet]
    [Route("")]
    public ActionResult Index() {
      return View(new HomeViewModel());
    }

    [HttpGet]
    [Route("add-request")]
    public ActionResult AddRequest() {
      return View(new AddRequestViewModel());
    }

    [HttpGet]
    [Route("permission-detail")]
    public ActionResult PermissionDetail() {
      return View(new PermissionDetailViewModel());
    }
  }
}