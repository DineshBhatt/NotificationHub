using System;
using NotificationhubDAL.Model;

namespace WebApplication1.Approval
{
    public partial class EventDeclinedPage : System.Web.UI.Page
    {
        NotificationhubModel RejectTheTemplate = new NotificationhubModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RejectTheTemplate.UpdateForRejectTamplate(Request.QueryString["Id"]);
            Response.Redirect("ManagerApprovalPage");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagerApprovalPage");
        }
    }
}