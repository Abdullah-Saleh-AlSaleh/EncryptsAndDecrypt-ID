using System.Web;
using System.Web.Mvc;

namespace Asp_net_Mvc_Encrypts_And_Decrypt_ID
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
