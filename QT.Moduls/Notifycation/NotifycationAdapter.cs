using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.Notifycation
{
    public class NotifycationAdapter
    {
        SqlDb sqlDb = new SqlDb("Data Source=192.168.100.178;Initial Catalog=Notification;Persist Security Info=True;User ID=sa;Password=123456a@;connection timeout=200");
        
        public DataTable GetNotifyOfUser (string User, int Processed)
        {
            return this.sqlDb.GetTblData("prc_Notification_GetByUser", CommandType.StoredProcedure,
                new System.Data.SqlClient.SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("UserName",User,SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("Processed",Processed,SqlDbType.Int)
                });
        }


        public void SaveChangeNotify(int ID, bool processed)
        {
            this.sqlDb.RunQuery("update [dbo].[Notification] set Processed = @processed, UserName = @UserName WHere ID = @ID", CommandType.Text,
                new SqlParameter[]{
                    SqlDb.CreateParamteterSQL("Processed",processed,SqlDbType.Bit),
                    SqlDb.CreateParamteterSQL("ID",ID,SqlDbType.Int),
                    SqlDb.CreateParamteterSQL("UserName",QT.Users.User.UserName,SqlDbType.NVarChar),
                });
        }

        internal int GetNumberMessageWait(string UserName, int Processed)
        {
            return QT.Entities.Common.Obj2Int(
                this.sqlDb.GetTblData("prc_Notification_GetByUser_Count", CommandType.StoredProcedure,
                new System.Data.SqlClient.SqlParameter[]
                {
                    SqlDb.CreateParamteterSQL("UserName",UserName,SqlDbType.NVarChar),
                    SqlDb.CreateParamteterSQL("Processed",Processed,SqlDbType.Int)
                }).Rows[0][0]);
        }

        public void InsertMessage(string queueNameData, string strMessage, int Processeed)
        {
            this.sqlDb.RunQuery("prc_Notification_Insert", CommandType.StoredProcedure, new SqlParameter[]{
                SqlDb.CreateParamteterSQL("@Queue",queueNameData,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@Message",strMessage,SqlDbType.NVarChar),
                SqlDb.CreateParamteterSQL("@Processed",Processeed,SqlDbType.NVarChar),
            });
        }
    }
}
