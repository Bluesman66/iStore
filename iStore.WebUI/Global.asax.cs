using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PerpetuumSoft.Knockout;

namespace iStore.WebUI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            ModelBinders.Binders.DefaultBinder = new KnockoutModelBinder();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
