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
        int QueryString = int.MinValue;
        string id= string.Empty;
        ListItem [] lm=new ListItem[4];


        protected void Page_Load(object sender, EventArgs e)
        {
            
            QueryString = Convert.ToInt32(Request.QueryString["Id"]);
            id = Context.User.Identity.GetUserId();
            Label1.Text = Context.User.Identity.GetUserName();
            Label2.Text = notificationhub.GetEventName(QueryString);
            notificationhub.GetChannelName(Context.User.Identity.GetUserId());
            for (int channelcount = 0; channelcount < notificationhub.channels.Count; channelcount++)
            {

                lm[channelcount] = new ListItem();
                lm[channelcount].Value = channelcount.ToString();
                lm[channelcount].Text = notificationhub.channels[channelcount].ChannelName;

                CheckBoxList1.Items.Add(lm[channelcount]);
                
            }
            notificationhub.insertIntoHomePage(id, QueryString);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int channelcount = 0; channelcount < notificationhub.channels.Count; channelcount++)
            {
                if (lm[channelcount].Selected)
                {
                    int ChannelId = notificationhub.channels[channelcount].channelId;
                    notificationhub.InsertIntoMyEventChannels(id, QueryString, ChannelId);
                }
            }


            notificationhub.insertIntoHomePage(id, QueryString);

            Response.Redirect("EndUserHomePage.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //notificationhub.DeleteToHomePage(Context.User.Identity.GetUserId());
            Response.Redirect("EndUserHomePage.aspx");
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}