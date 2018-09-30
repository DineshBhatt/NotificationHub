using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationhubDAL.Repository;


namespace NotificationhubDAL.Model
{
    public class NotificationhubModel
    {
        public SqlConnection sqlConnection = null;
        public SqlConnection ConnectionOpen()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=ACUPC_117;Initial Catalog=NotificationHub;Integrated Security=True";
            sqlConnection.Open();
            return sqlConnection;
        }

        public List<NotificationHubHomePageRepository> HomePageList = new List<NotificationHubHomePageRepository>();
        public List<NotificationHubHomePageRepository> getDetailsOfHomePage()
        {
            
            string ReteriveforHomePageQuery = "select e.Name, ess.EventId from Event e, Event_slm_subscribe ess where ess.EventId = e.Id;";
            using (SqlCommand HomeCommand = new SqlCommand(ReteriveforHomePageQuery, ConnectionOpen()))
            {
                
                using (SqlDataReader mydatareader = HomeCommand.ExecuteReader())
                {
                    while (mydatareader.Read()) {

                        HomePageList.Add(new NotificationHubHomePageRepository
                        {
                            EventName = mydatareader["Name"].ToString(),
                            EventId = Convert.ToInt32(mydatareader["EventId"]),
                            //userid = mydatareader[""]
                        });

                    }
                }
                connectionClose();
            }
            return HomePageList;
        }

        //public string[] ChannelArray()
        //{
        //    NotificationHubHomePageRepository ForChannels = new NotificationHubHomePageRepository();
        //    string[] channelsName = new string[4];
        //    int i = 0;
            
        //    string query = "select * from Channel";
        //    using (SqlCommand mycommand = new SqlCommand(query, ConnectionOpen()))
        //    {
        //        SqlDataReader channels = mycommand.ExecuteReader();
        //        while (channels.Read())
        //        {
        //            ForChannels.ChannelsSelected = channels["Name"].ToString();
        //            channelsName[i] = ForChannels.ChannelsSelected;
        //            i++;
        //        }
        //    }
        //    return channelsName;
        //}

        public List<NotificationHubApprovalRepository> approvalPageList = new List<NotificationHubApprovalRepository>();
        public List<NotificationHubApprovalRepository> getdetailsOfApproval()
        {
            string RetriveForApprovalPageQuery = "select t.Name, t.OperationManagerId, anu.UserName from Template t, AspNetUsers anu where t.OperationManagerId = anu.Id and t.ApprovalStatusId in (1 , 2)";
            using (SqlCommand Approvalcommand = new SqlCommand(RetriveForApprovalPageQuery, ConnectionOpen()))
            {
                using (SqlDataReader ApprovalReader = Approvalcommand.ExecuteReader())
                {
                    while (ApprovalReader.Read())
                    {
                        approvalPageList.Add(new NotificationHubApprovalRepository
                        {
                            TemplateName = ApprovalReader["Name"].ToString(),
                            operationalManagerName = ApprovalReader["UserName"].ToString(),
                            OperationManagerId = ApprovalReader["OperationManagerId"].ToString(),
                        }
                            );
                    }
                }
            }

                return approvalPageList;
        }
//
        public DataSet HomeGridView(string userId)
        {
            string query = "select e.Name, e.Id from Event e, Event_slm_subscribe ess, Event_slm_subscribe_users essu where ess.EventId=e.Id and ess.Id = essu.Event_slm_subscribe_Id and essu.UserId='" + userId+"'";
            SqlCommand cmd = new SqlCommand(query, ConnectionOpen());
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public List<Channels> channels = new List<Channels>();
        public List<Channels> GetChannelName(string UserId)
        {
           
            string query = "select ch.Name, ch.Id from Channel ch, Event_slm_subscribe_channel essc, Event_slm_subscribe_users essu " +
                "where essu.Event_slm_subscribe_Id = essc.Event_slm_subscribe_Id and essc.ChannelId = ch.Id and essu.UserId = '" + UserId + "'";
            using (SqlCommand ChannelCommand = new SqlCommand(query, ConnectionOpen()))
            {
                SqlDataReader ChannelReader = ChannelCommand.ExecuteReader();
                
                while (ChannelReader.Read())
                {
                    channels.Add(new Channels()
                    {
                        ChannelName = ChannelReader["Name"].ToString(),
                        channelId = Convert.ToInt32(ChannelReader["Id"].ToString()),
                    });
                }
            }
            return channels;
        }
        public void insertIntoHomePage(string UserId, int EventId)
        {
            //string query = "insert into MyEvents (UserId, EventId, Subscribed) values {@parqameter1, @parameter2, @Parameter3}";
            string query = "insert into MyEvents(UserId, EventId, Subscribed) values(@parameter1, @parameter2, @Parameter3)";

            using (SqlCommand myCommand = new SqlCommand(query, ConnectionOpen()))
            {
                SqlParameter sqlParameter = new SqlParameter()
                {
                    ParameterName = "@parameter1",
                    Value = UserId,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 200,
                };
                myCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter()
                {
                    ParameterName = "@parameter2",
                    Value = EventId,
                    SqlDbType = SqlDbType.Int,
                    Size = 20,
                };
                myCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter()
                {
                    ParameterName = "@Parameter3",
                    Value = true,
                    SqlDbType = SqlDbType.Bit,
                    
                };
                myCommand.Parameters.Add(sqlParameter);

                myCommand.ExecuteNonQuery();
            }
            connectionClose();
        }
        public void InsertIntoMyEventChannels(string UserId, int EventId, int ChannelId)
        {
            //string query = "select c.Name, mc.*, essc.* from Channel c, MyEventsChannel mc, Event_slm_subscribe_channel essc where mc.Channelid = essc.ChannelId and mc.Channelid = c.Id;"
            string Query = "insert into MyEventsChannel (UserId, EvenetId, Channelid) values (@Parameter1, @Parameter2, @Parameter3)";
            using (SqlCommand myCommand = new SqlCommand(Query, ConnectionOpen()))
            {
                SqlParameter sqlParameter = new SqlParameter()
                {
                    ParameterName = "@Parameter1",
                    Value = UserId,
                    SqlDbType = SqlDbType.NVarChar,
                    Size= 200,
                };
                myCommand.Parameters.Add(sqlParameter);


                sqlParameter = new SqlParameter()
                {
                    ParameterName = "@Parameter2",
                    Value = EventId,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                };
                myCommand.Parameters.Add(sqlParameter);


                sqlParameter = new SqlParameter()
                {
                    ParameterName = "@Parameter3",
                    Value = ChannelId,
                    SqlDbType = SqlDbType.Int,
                    Size = 10,
                };
                myCommand.Parameters.Add(sqlParameter);

                myCommand.ExecuteNonQuery();
            }
            connectionClose();
        }
        public void UpdateintoTemplateAproovalId(string UserId)
        {
            string sql = $"update Template set ApprovalStatusId = 2 where OperationManagerId ='{UserId}'";
            using (SqlCommand command = new SqlCommand(sql, ConnectionOpen()))
            {
                command.ExecuteNonQuery();
            }
            connectionClose();
        }
        public void UpdateForRejectTamplate(String UserId)
        {
            string sql = $"update Template set ApprovalStatusId = 3 where OperationManagerId ='{UserId}'";
            using (SqlCommand command = new SqlCommand(sql, ConnectionOpen()))
            {
                command.ExecuteNonQuery();
            }
            connectionClose();
        }
        public void DeleteToTemplate(string id)
        {
            string sql = $"Delete from Template where OperationId = '{id}'";
            using (SqlCommand cmd = new SqlCommand(sql, ConnectionOpen()))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry! That car is on order!", ex);
                    throw error;
                }
            }

        }


        public SqlConnection connectionClose()
        {
            sqlConnection.Close();
            return sqlConnection;
        }
    }
}
