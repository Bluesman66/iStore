using System.Web.Optimization;

namespace iStore.WebUI
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/css/font-awesome.css",
                "~/Content/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.mapping-latest.js",
                "~/Scripts/perpetuum.knockout.js",
                "~/Scripts/bootstrap.js"));
        }
    }
}