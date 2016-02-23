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
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular/angular.min.js",
                      "~/Scripts/angular/angular-animate.min.js",
                      "~/Scripts/angular/angular-aria.min.js",
                      "~/Scripts/angular/angular-cookies.min.js",
                      "~/Scripts/angular/angular-loader.min.js",
                      "~/Scripts/angular/angular-message-format.min.js",
                      "~/Scripts/angular/angular-messages.min.js",
                      "~/Scripts/angular/angular-mocks.js",
                      "~/Scripts/angular/angular-resource.min.js",
                      "~/Scripts/angular/angular-route.min.js",
                      "~/Scripts/angular/angular-sanitize.min.js",
                      //"~/Scripts/Angular/angular-scenario.js",
                      "~/Scripts/angular/angular-touch.min.js"
                      ));
            //Angular libraries
            bundles.Add(new ScriptBundle("~/bundles/angular-ui").Include(
                      "~/Scripts/angular-ui/angular-material.min.js"));


            //Angular Application 
            bundles.Add(new ScriptBundle("~/bundles/Application").Include(
                      "~/Scripts/app/Application.js"));

            //Angular Services
            bundles.Add(new ScriptBundle("~/bundles/Services").Include(
                      "~/Scripts/app/Services/*.js"));

            //Angular Controllers
            bundles.Add(new ScriptBundle("~/bundles/Controllers").Include(
                      "~/Scripts/app/Controllers/*.js"));

            //Angular Directives
            bundles.Add(new ScriptBundle("~/bundles/Directives").Include(
                      "~/Scripts/app/Directives/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
