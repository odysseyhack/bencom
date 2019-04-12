using System.Web;
using System.Web.Mvc;

namespace BenChain.Web.AdminLTE {
  public class FilterConfig {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
