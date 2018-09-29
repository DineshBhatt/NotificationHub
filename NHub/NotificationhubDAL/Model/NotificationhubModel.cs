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

        public string[] ChannelArray()
        {
            NotificationHubHomePageRepository ForChannels = new NotificationHubHomePageRepository();
            string[] channelsName = new string[4];
            int i = 0;
            
            string query = "select * from Channel";
            using (SqlCommand mycommand = new SqlCommand(query, ConnectionOpen()))
            {
                SqlDataReader channels = mycommand.ExecuteReader();
                while (channels.Read())
                {
                    ForChannels.ChannelsSelected = channels["Name"].ToString();
                    channelsName[i] = ForChannels.ChannelsSelected;
                    i++;
                }
            }
            return channelsName;
        }

        public List<NotificationHubApprovalRepository> approvalPageList = new List<NotificationHubApprovalRepository>();
        public List<NotificationHubApprovalRepository> getdetailsOfApproval()
        {
            string RetriveForApprovalPageQuery = "select * from Template";
            using (SqlCommand Approvalcommand = new SqlCommand(RetriveForApprovalPageQuery, ConnectionOpen()))
            {
                using (SqlDataReader ApprovalReader = Approvalcommand.ExecuteReader())
                {
                    while (ApprovalReader.Read())
                    {
                        approvalPageList.Add(new NotificationHubApprovalRepository
                        {
                            TemplateName = ApprovalReader["TemplateName"].ToString(),
                            operationalManagerName = ApprovalReader["UserName"].ToString(),
                        }
                            );
                    }
                }
            }

                return approvalPageList;
        }

        public DataSet HomeGridView()
        {
            string query = "select Name from Event";
            SqlCommand cmd = new SqlCommand(query, ConnectionOpen());
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public void insertIntoHomePage(string UserId, string EventId)
        {
            string query = "insert into MyEvent (UserId, EventId, Subscribed) value {@parqameter1, @parameter2, @Parameter3}";
            
            using (SqlCommand myCommand = new SqlCommand(query, ConnectionOpen()))
            {
                SqlParameter sqlParameter = new SqlParameter()
                {
                    ParameterName = "@parameter1",
                    Value = UserId,
                    SqlDbType = SqlDbType.Char,
                    Size = 20,
                };
                myCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter()
                {
                    ParameterName = "@parameter2",
                    Value = EventId,
                    SqlDbType = SqlDbType.Char,
                    Size = 20,
                };
                myCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter()
                {
                    ParameterName = "@Parameter3",
                    Value = "1",
                    SqlDbType = SqlDbType.Bit,
                    
                };
                myCommand.Parameters.Add(sqlParameter);

                myCommand.ExecuteNonQuery();
            }
            connectionClose();
        }

        public void UpdateintoHomePage(string newPetName, int id)
        {
            ConnectionOpen();
            // Get ID of car to modify and new pet name.
            string sql = $"Update Inventory Set PetName = '{newPetName}' Where CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql, ConnectionOpen()))
            {
                command.ExecuteNonQuery();
            }

        }

        public void DeleteToHomePage(string id)
        {
            string sql = $"Delete from Inventory where CarId = '{id}'";
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
