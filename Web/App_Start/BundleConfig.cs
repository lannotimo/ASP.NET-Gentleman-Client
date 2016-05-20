﻿using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region SCRIPTS

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


            bundles.Add(new ScriptBundle("~/bundles/jqueryExtra").Include(
                      "~/Scripts/Theme/jquery.nav.js",
                      "~/Scripts/Theme/jquery.fitvids.js",
                      "~/Scripts/Theme/jquery.ajaxchimp.js",
                      "~/Scripts/Theme/jquery.scrollTo.js",
                      "~/Scripts/Theme/jquery.localScroll.js"));

            bundles.Add(new ScriptBundle("~/bundles/Theme").Include(
                      "~/Scripts/Theme/preloader.js",
                      "~/Scripts/Theme/retina.js",
                      "~/Scripts/Theme/owl.carousel.js",
                      "~/Scripts/Theme/nivo-lightbox.js",
                      "~/Scripts/Theme/simple-expand.js",
                      "~/Scripts/Theme/custom.js"));

            #endregion

            #region STYLES

                   bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Theme").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Theme/assets/font-awesome/css/font-awesome.min.css",
                      "~/Content/Theme/css/colors/color.css",
                      "~/Content/Theme/css/preloader.css",
                      "~/Content/Theme/css/style.css",
                      "~/Content/Theme/css/responsive.css"));

            bundles.Add(new StyleBundle("~/Content/Theme/css").Include(
                      "~/Content/Theme/css/owl.theme.css",
                      "~/Content/Theme/css/owl.carousel.css",
                      "~/Content/Theme/css/nivo-lightbox.css",
                      "~/Content/Theme/css/themes/default/default.css"
                      ));

            #endregion
        }
    }
}
