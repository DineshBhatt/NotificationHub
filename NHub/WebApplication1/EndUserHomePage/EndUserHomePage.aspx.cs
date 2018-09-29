using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotificationhubDAL.Model;
using System.Data;

namespace WebApplication1.EndUserHomePage
{
    public partial class EndUserHomePage : System.Web.UI.Page
    {
        NotificationhubModel notificationhubModel = new NotificationhubModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            //notificationhubModel.getDetailsOfHomePage();
            //GridView gridView = new GridView();
            //gridView.ID = "HomePage";
            //Table HomePage = new Table();
            //HomePage.ID = "Homepage";
            ////gridView.DataSource = HomePage;
            //TableRow Rows;
            //for (int GridRowCount = 0; GridRowCount < notificationhubModel.HomePageList.Count; GridRowCount++)
            //{
            //    Rows = new TableRow();
            //    Rows.ID = "Rows";
            //    BoundField EventName = new BoundField();
            //    EventName.HeaderText = "Event Name";
            //    EventName.DataField = notificationhubModel.HomePageList[GridRowCount].EventName;
            //    gridView.Columns.Add(EventName);
            //    ButtonField Subscribed = new ButtonField();
            //    Subscribed.HeaderText = "Subscribed";
            //    Subscribed.DataTextFormatString = "ON/OFF";
            //    gridView.Columns.Add(Subscribed);
            //    CheckBoxField Channels = new CheckBoxField();
            //    Channels.HeaderText = "Channels";
            //    CheckBoxList channel = new CheckBoxList();
            //    channel.DataSource = notificationhubModel.ChannelArray();
            //    channel.DataBind();

            //    gridView.Columns.Add(Channels);

            //    HyperLinkField Update = new HyperLinkField();
            //    Update.HeaderText = "";
            //    Update.DataTextField = "update";
            //    Update.NavigateUrl = "Acceptence.aspx";
            //    gridView.Columns.Add(Update);
            //}
            //gridView.DataSource = gridView;
            //gridView.DataBind();
            //PlaceHolder1.Controls.Add(gridView);


            NotificationhubModel homeGrid = new NotificationhubModel();
            GridView.DataSource = homeGrid.HomeGridView();
            GridView.DataBind();
        }


        protected void GridView_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
        }

       
    }
}