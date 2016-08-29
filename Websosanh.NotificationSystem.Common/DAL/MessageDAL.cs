using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.NotificationSystem.Common
{
    public class MessageDAL
    {
        private string m_ConnectionString;
        public MessageDAL()
        {
            if (ConfigurationManager.ConnectionStrings["BackupMessageNotification"] == null)
                throw new Exception("ConnectionString BackupMessageNotification has not been configurationed");
            m_ConnectionString = ConfigurationManager.ConnectionStrings["BackupMessageNotification"].ConnectionString;
        }
        public long InsertMessage(string message, string exchange, string routingKey )
        {
            using (SqlConnection cnn = new SqlConnection(m_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[prc_MessageNotification_Insert]", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MessageID", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@MessageContent", message);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@exchange", exchange);
                    cmd.Parameters.AddWithValue("@routingKey", routingKey);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return Convert.ToInt64(cmd.Parameters["@MessageID"].Value);
                }
            }
        }
        public List<MessageEntity> GetData(int numberOfRows)
        {
            List<MessageEntity> glstMessage = new List<MessageEntity>();
            using (SqlConnection Cnn = new SqlConnection(m_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spMessageNotificateion_Get", Cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@numberOfRow", numberOfRows);
                    Cnn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (dr.HasRows)
                            {
                                MessageEntity objMessage = new MessageEntity();
                                objMessage.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
                                objMessage.MessageContent = dr["MessageContent"].ToString();
                                objMessage.MessageID = Convert.ToInt64(dr["MessageID"]);
                                objMessage.QueueName = dr["QueueName"].ToString();
                                glstMessage.Add(objMessage);
                            }
                        }
                        dr.Close();
                    }
                    Cnn.Close();
                }
            }
            return glstMessage;
        }
        public bool ExecuteQuery(string query)
        {
            using (SqlConnection cnn = new SqlConnection(m_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
    }
}
