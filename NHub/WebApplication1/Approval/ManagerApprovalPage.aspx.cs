using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationhubDAL.Model;
using NotificationhubDAL.Repository;
using Microsoft.AspNet.Identity;

namespace WebApplication1.Approval
{
    public partial class ManagerApprovalPage : System.Web.UI.Page
    {
        NotificationhubModel notificationHubModel = new NotificationhubModel();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            notificationHubModel.getdetailsOfApproval();
            if (!Page.IsPostBack)
            {
               
                for (int templatecount = 0; templatecount < notificationHubModel.approvalPageList.Count; templatecount++)
                {
                    Label NewTemplate = new Label();
                    NewTemplate.ID = "NewTemplate" + templatecount;
                    PlaceHolder1.Controls.Add(NewTemplate);
                    NewTemplate.Text = (">_New_Template");
                    NewTemplate.Font.Bold = true;
                    NewTemplate.Font.Size = 15;
                    NewTemplate.Width = 200;
                    Label TemplateName = new Label();
                    TemplateName.ID = "Label1" + templatecount;
                    PlaceHolder1.Controls.Add(TemplateName);
                    TemplateName.Text = notificationHubModel.approvalPageList[templatecount].TemplateName;
                    TemplateName.Font.Bold = true;
                    TemplateName.Font.Size = 15;
                    TemplateName.Width = 150;
                    Label OperationalManagerName = new Label();
                    OperationalManagerName.ID = "OperationalManagerName" + templatecount;
                    PlaceHolder1.Controls.Add(OperationalManagerName);
                    OperationalManagerName.Text = notificationHubModel.approvalPageList[templatecount].operationalManagerName;
                    OperationalManagerName.Font.Bold = true;
                    OperationalManagerName.Font.Size = 15;
                    OperationalManagerName.Width = 300;
                    HyperLink hyperlink = new HyperLink();
                    hyperlink.ID = "Accepted" + templatecount;
                    PlaceHolder1.Controls.Add(hyperlink);
                    hyperlink.Font.Bold = true;
                    hyperlink.Font.Size = 15;
                    hyperlink.Text = "Accepted";
                    hyperlink.NavigateUrl = "EventAprovalPage.aspx?Id="+notificationHubModel.approvalPageList[templatecount].OperationManagerId;
                    hyperlink.Width = 150;
                    HyperLink hyperLink = new HyperLink();
                    hyperLink.ID = "Declined"+templatecount;
                    PlaceHolder1.Controls.Add(hyperLink);
                    hyperLink.Font.Bold = true;
                    hyperLink.Font.Size = 15;
                    hyperLink.Text = "Declined";
                    hyperLink.Width = 150;
                    hyperLink.NavigateUrl = "ManagerApprovalPage.aspx?Id="+ notificationHubModel.approvalPageList[templatecount].OperationManagerId;


                }
            }
            else
            {
                string QueryString = Request.QueryString["Id"].ToString();
                if (QueryString != null)
                {
                    notificationHubModel.UpdateForRejectTamplate(QueryString);
                }
            }
            
        }


    }
}