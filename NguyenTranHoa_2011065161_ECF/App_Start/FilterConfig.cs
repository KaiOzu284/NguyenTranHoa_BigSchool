using System.Web;
using System.Web.Mvc;

namespace NguyenTranHoa_2011065161_ECF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
