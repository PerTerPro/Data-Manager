using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.NotificationSystem.Common.DAL
{
    public class ChannelDAL
    {
        private string m_ConnectionString;
        public ChannelDAL()
        {
            m_ConnectionString = DefaultConnection.GetConnectionString();
        }

        public bool CheckChannelNameExist(string channelName)
        {
            string query = "SELECT ChannelID FROM Channel where ChannelName = @ChannelName";
            using (SqlConnection cnn = new SqlConnection(m_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@ChannelName", channelName);
                    cnn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                            return true;
                        dr.Close();
                    }
                    cnn.Close();
                }
            }
            return false;
        }
    }
}
