using System.Web.Optimization;

namespace Established_Patient_Form
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

            //Angular libraries
            bundles.Add(new ScriptBundle("~/bundles/Angular").Include(
                      "~/Scripts/Angular/angular.min.js",
                      "~/Scripts/Angular/angular-animate.min.js",
                      "~/Scripts/Angular/angular-aria.min.js",
                      "~/Scripts/Angular/angular-cookies.min.js",
                      "~/Scripts/Angular/angular-loader.min.js",
                      "~/Scripts/Angular/angular-message-format.min.js",
                      "~/Scripts/Angular/angular-messages.min.js",
                      "~/Scripts/Angular/angular-mocks.js",
                      "~/Scripts/Angular/angular-resource.min.js",
                      "~/Scripts/Angular/angular-route.min.js",
                      "~/Scripts/Angular/angular-sanitize.min.js",
                      //"~/Scripts/Angular/angular-scenario.js",
                      "~/Scripts/Angular/angular-touch.min.js"
                      ));
            //Angular libraries
            bundles.Add(new ScriptBundle("~/bundles/Angular-Material").Include(
                      "~/Scripts/Angular-Material/angular-material.min.js"));


            //Angular Application 
            bundles.Add(new ScriptBundle("~/bundles/Application").Include(
                      "~/Scripts/Application/Application.js"));

            //Angular Services
            bundles.Add(new ScriptBundle("~/bundles/Services").Include(
                      "~/Scripts/Application/Services/*.js"));

            //Angular Controllers
            bundles.Add(new ScriptBundle("~/bundles/Controllers").Include(
                      "~/Scripts/Application/Controllers/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
