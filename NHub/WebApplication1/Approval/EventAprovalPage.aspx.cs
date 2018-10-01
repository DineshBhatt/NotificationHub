using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationhubDAL.Model;
using Microsoft.AspNet.Identity;

namespace WebApplication1.Approval
{
    public partial class EventAprovalPage : System.Web.UI.Page
    {
        NotificationhubModel notificationHubModel = new NotificationhubModel();
        string QueryString;
        protected void Page_Load(object sender, EventArgs e)
        {
            QueryString = Request.QueryString["Id"];
            for (int TemplateCount = 0; TemplateCount < notificationHubModel.HomePageList.Count; TemplateCount++)
            {
                //if(QueryString==TemplateCount)
                //{
                //    //notificationHubModel.DeleteToHomePage();
                //}
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            notificationHubModel.UpdateintoTemplateAproovalId(QueryString);
            Response.Redirect("ManagerApprovalPage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagerApprovalPage.aspx");
        }
    }
}