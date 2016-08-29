using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QT.Entities;

namespace QT.Moduls.Crawler
{
    public class ManagerCrawler
    {
        private Company.DBComTableAdapters.ManagerCrawlerTableAdapter adt;
        private Company.DBCom.ManagerCrawlerDataTable dt;
        public ManagerCrawler()
        {
            adt = new Company.DBComTableAdapters.ManagerCrawlerTableAdapter();
            dt = new Company.DBCom.ManagerCrawlerDataTable();
            adt.Connection.ConnectionString = Server.ConnectionString;
        }
        public void Insert(int idManagerYpe, int commandCrawler, int online, string comment)
        {
            try
            {
                adt.Insert(
                    idManagerYpe, DateTime.Now, commandCrawler, online, QT.Users.User.UserID, comment);
            }
            catch (Exception)
            {
            }
        }
        ~ManagerCrawler()
        {
            adt.Dispose();
            dt.Dispose();
        }
    }
}
