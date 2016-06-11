using System.Web.Mvc; 
using System.Web.Routing;
using WebPlatform;

namespace Krokot.Web
{
    public class MvcApplication : WebApplicationStartup
    {
        public override void Startup()
        { 
            base.Settings.Security.EnableAuthentication = false; 
            base.Settings.Landing.MaintenanceController = "Maintenance";
            base.Settings.Landing.LandingController = "Landing";
            base.Settings.Security.LoginControlller = "Login";
            base.Settings.Security.UnauthorizedControlller = "Unauthorized";
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("id-ID");

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes); 
        }
    }
}
