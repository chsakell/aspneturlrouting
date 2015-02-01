using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Routing;

namespace AspNetUrlRouting.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("default", "", "~/Default.aspx");
            routes.MapPageRoute("students1", "students", "~/Univercity/Students.aspx");
            routes.MapPageRoute("students2", "univercity/students", "~/Univercity/Students.aspx");
            //routes.MapPageRoute("default_all", "{anything}/default", "~/Default.aspx");
            routes.MapPageRoute("default_all", "{anything}/default", "~/Default.aspx",
                false, null,
                new RouteValueDictionary { { "anything", "univercity|school|classes" } });
            routes.MapPageRoute("hack_student", "get/students/{id}", "~/Univercity/Students.aspx",
                false, null,
                new RouteValueDictionary { { "id", "[0-9]*" } });
        }
    }
}