using RandomQuotes.ErrorHandling;
using System.Web.Mvc;

namespace RandomQuotes
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AiHandleErrorAttribute());
        }
    }
}
