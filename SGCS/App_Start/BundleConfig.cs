using System.Web;
using System.Web.Optimization;

namespace SGCS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/gentella/css").Include(
                      "~/Content/gentella/css/bootstrap.min.css",
                      "~/Content/gentella/fonts/css/font-awesome.min.css",
                      "~/Content/gentella/css/animate.min.css",
                      "~/Content/gentella/css/custom.css",
                      "~/Content/gentella/css/icheck/flat/green.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/Content/gentella/js").Include(
                      "~/Content/gentella/js/chartjs/chart.min.js",
                      "~/Content/gentella/js/progressbar/bootstrap-progressbar.min.js",
                      "~/Content/gentella/js/nicescroll/jquery.nicescroll.min.js",
                      "~/Content/gentella/js/icheck/icheck.min.js",
                      "~/Content/gentella/js/custom.js"));
        }
    }
}
