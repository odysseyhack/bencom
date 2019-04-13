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

    public ActionResult About() {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact() {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}