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
            NotificationhubModel notificationHubModel = new NotificationhubModel();
            notificationHubModel.getdetailsOfApproval();

            for (int templatecount = 0; templatecount < notificationHubModel.approvalPageList.Count; templatecount++)
            {
                Label TemplateName = new Label();
                TemplateName.ID = "Label1";
                PlaceHolder1.Controls.Add(TemplateName);
                TemplateName.Text = notificationHubModel.approvalPageList[templatecount].TemplateName;
                TemplateName.Width = 400;
                Label OperationalManagerName = new Label();
                OperationalManagerName.ID = "OperationalManagerName";
                PlaceHolder1.Controls.Add(OperationalManagerName);
                OperationalManagerName.Text = notificationHubModel.approvalPageList[templatecount].operationalManagerName;
                OperationalManagerName.Width = 300;
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

                ///label.Text = "New Template-NewHire_Finance " + "Dinesh bhatt"  /*notificationHubModel.ApprovalList[0].EventName.ToString();*/;
                //label.Width = 900;


            }

        }

        
    }
}