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
            sqlConnection.ConnectionString = "";
            sqlConnection.Open();
            return sqlConnection;
        }

        public List<NotificationHubRepository> ApprovalList;
        public List<NotificationHubRepository> getDetailsOfteNotification()
        {
            string query = "select * from Table";
            using (SqlCommand myCommand = new SqlCommand(query, ConnectionOpen()))
            {
                using (SqlDataReader mydatareader = myCommand.ExecuteReader())
                {
                    ApprovalList = new List<NotificationHubRepository>();
                    ApprovalList.Add(new NotificationHubRepository
                    {
                        EventName = mydatareader["if"].ToString(),
                        Subscription = Convert.ToBoolean(mydatareader["sub"]),
                        ChannelsSelected = mydatareader["channel"].ToString(),
                    });
                }
            }
            return ApprovalList;
        }


        public void insertInto(string parameter1, string parameter2)
        {
            string query = "insert into Table (column1, column2) value {@parqameter1, parameter2}";
            
            using (SqlCommand myCommand = new SqlCommand(query, ConnectionOpen()))
            {
                SqlParameter sqlParameter = new SqlParameter()
                {
                    ParameterName = @parameter1,
                    Value = parameter1,
                    SqlDbType = SqlDbType.Char,
                    Size = 20,
                };
                sqlParameter = new SqlParameter()
                {
                    ParameterName = @parameter2,
                    Value = parameter2,
                    SqlDbType = SqlDbType.Char,
                    Size = 20,
                };
            }
            connectionClose();
        }

        public void UpdateintoTable(string newPetName, int id)
        {
            ConnectionOpen();
            // Get ID of car to modify and new pet name.
            string sql = $"Update Inventory Set PetName = '{newPetName}' Where CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql, ConnectionOpen()))
            {
                command.ExecuteNonQuery();
            }

        }

        public void deleteToTable(string id)
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
