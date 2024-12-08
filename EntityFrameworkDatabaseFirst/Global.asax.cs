using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EntityFrameworkDatabaseFirst
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbConfiguration.SetConfiguration(new MicrosoftSqlDbConfiguration());
        }
    }
}
