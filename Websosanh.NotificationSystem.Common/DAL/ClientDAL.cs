using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websosanh.NotificationSystem.Common.DAL
{
    public class ClientDAL
    {
        private string m_ConnectionString;
        public ClientDAL()
        {
            m_ConnectionString = DefaultConnection.GetConnectionString();
        }

        public bool IsClientValid(string registrationCode, string password)
        {
            if (string.IsNullOrEmpty(registrationCode))
                return false;
            string query = "SELECT ClientID FROM Client where RegistrationCode = @registrationCode AND IsActive = 'true' AND Password = @Password";
            using(SqlConnection cnn = new SqlConnection(m_ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@registrationCode", registrationCode);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cnn.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader())
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
