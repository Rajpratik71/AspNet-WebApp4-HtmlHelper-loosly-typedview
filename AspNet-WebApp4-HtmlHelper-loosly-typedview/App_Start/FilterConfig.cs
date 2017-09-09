using System.Web;
using System.Web.Mvc;

namespace AspNet_WebApp4_HtmlHelper_loosly_typedview
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
