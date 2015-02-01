using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Routing;

namespace AspNetUrlRouting.Univercity
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null && myRoute.Url == "get/students/{id}")
            {
                string id = RouteData.Values["id"].ToString();
                Response.Write("Student: " + id + "<br/>" +
                    "Name: Chris");
            }
        }
    }
}