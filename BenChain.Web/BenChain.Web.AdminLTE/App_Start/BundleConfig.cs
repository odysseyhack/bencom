using System.Web;
using System.Web.Optimization;

namespace BenChain.Web.AdminLTE {
  public class BundleConfig {
    // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles) {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Content/Scripts/Vendor/jquery-{version}.js",
                  "~/node_modules/admin-lte/bower_components/jquery-slimscroll/jquery.slimscroll.min.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Content/Scripts/Vendor/jquery.validate*"));

      bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                  "~/node_modules/admin-lte/bower_components/fastclick/lib/fastclick.js",
                  "~/node_modules/admin-lte/dist/js/adminlte.min.js",
                  "~/Content/Scripts/AdminLTE-Addon.js"));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Content/Scripts/Vendor/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Content/Scripts/Vendor/bootstrap.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Styles/Vendor/bootstrap.css",
                "~/Content/Styles/Styles.css"));
    }
  }
}
