using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WEBAPP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            #region 静态页面路由映射
            routes.MapPageRoute("","Home","~/Views/Home/index.html");
            routes.MapPageRoute("", "test", "~/Views/test.html");
            routes.MapPageRoute("", "test2", "~/Views/test2.html");
            routes.MapPageRoute("", "why", "~/Views/why/index.html");
            routes.MapPageRoute("", "QuestionList", "~/Views/why/QuestionList.html");//QuestionList
            #endregion

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}