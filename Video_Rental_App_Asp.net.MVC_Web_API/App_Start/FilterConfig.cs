using System.Web;
using System.Web.Mvc;

namespace Video_Rental_App_Asp.net.MVC_Web_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
