using System.Web;
using System.Web.Mvc;

namespace IntranetPOPS1819
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
