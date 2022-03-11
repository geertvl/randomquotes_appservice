using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using RandomQuotes.Infrastructure;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RandomQuotes
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            TelemetryClientAccessor.Instance = new TelemetryClient(TelemetryConfiguration.CreateDefault());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            QuoteLoader.Initialize();
        }
    }
}
