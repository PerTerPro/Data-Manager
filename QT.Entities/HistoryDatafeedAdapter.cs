using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Entities
{
    public class HistoryDatafeedAdapter
    {
        public static readonly ILog Log = LogManager.GetLogger(typeof(HistoryDatafeedAdapter));
        public static void InsertHistory(long companyID, string datafeedUrl,int totalProductRecive, int totalProductValid, int totalProductUnValid,string errorMessage)
        {
            int userID = 0;
            if (Server.UserID != 0)
                userID = Server.UserID;
            DBJobTableAdapters.HistoryDatafeedTableAdapter historyAdapter = new DBJobTableAdapters.HistoryDatafeedTableAdapter();
            historyAdapter.Connection.ConnectionString = Server.ConnectionString;
            try
            {
                historyAdapter.Insert(companyID, datafeedUrl, totalProductRecive, totalProductValid, totalProductUnValid, DateTime.Now ,errorMessage,userID);
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("ERROR insert history with CompanyID = {0}", companyID), ex);
            }
        }
    }
}
