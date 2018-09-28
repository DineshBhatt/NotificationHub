using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationhubDAL.Model;
using NotificationhubDAL.Repository;

namespace WebApplication1.Approval
{
    public partial class ManagerApprovalPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int templatecount = 0; templatecount < 6; templatecount++)
            {
                NotificationhubModel notificationHubModel = new NotificationhubModel();
                notificationHubModel.getDetailsOfteNotification();
                Label label = new Label();
                label.ID = "LAbel1";
                PlaceHolder1.Controls.Add(label);
                HyperLink hyperlink = new HyperLink();
                hyperlink.ID = "hyperlink1";
                PlaceHolder1.Controls.Add(hyperlink);
               
                hyperlink.Text = "Accepted";
                hyperlink.NavigateUrl = "EventAprovalPage";
                hyperlink.Width = 100;
                HyperLink hyperLink = new HyperLink();
                hyperLink.ID = "hyperlink2";
                PlaceHolder1.Controls.Add(hyperLink);
                
               // hyperLink.NavigateUrl = "Templates.aspx";
                hyperLink.Text = "Declined";
                hyperLink.Width = 100;

                label.Text = "New Template-NewHire_Finance " + "Dinesh bhatt"  /*notificationHubModel.ApprovalList[0].EventName.ToString();*/;
                label.Width = 900;


            }

        }

        
    }
}