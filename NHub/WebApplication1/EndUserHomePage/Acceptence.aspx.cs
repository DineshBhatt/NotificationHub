using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using NotificationhubDAL.Model;

namespace WebApplication1.EndUserHomePage
{
    public partial class Acceptence : System.Web.UI.Page
    {
        NotificationhubModel notificationhub = new NotificationhubModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string QueryString = Request.QueryString["id"];
            string id = Context.User.Identity.GetUserId();
            notificationhub.insertIntoHomePage(id, QueryString);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EndUserHomePage.aspx");
        }
    }
}