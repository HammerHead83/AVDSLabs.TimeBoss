using System.Web;
using System.Web.Mvc;

namespace AVDSLabs.TimeBoss2.TaskBoss
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
