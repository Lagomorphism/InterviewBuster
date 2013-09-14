using System.Web;
using System.Web.Mvc;

namespace InterviewBuster.UI.Web.REST
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}