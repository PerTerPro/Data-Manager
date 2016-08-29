using System.Collections.Generic;
using QT.Entities.DsQTCrawlerTableAdapters;

namespace QT.Entities.CrawlerProduct
{
    public class QtCrawlerQueueAdapter
    {
        private QueueTableAdapter adapter = null;
        public QtCrawlerQueueAdapter(string connection)
        {
            adapter = new QueueTableAdapter();
            adapter.Connection.ConnectionString = connection;
        }

        public List<JobFindNew> GetOldQueue(long companyId)
        {
            var lst = new List<JobFindNew>();
            var tbl = adapter.GetByCompany(companyId);
            foreach (var a in tbl.Rows)
            {
                DsQTCrawler.QueueRow row = a as
                    DsQTCrawler.QueueRow;
                if (row != null)
                    lst.Add(new JobFindNew()
                    {
                        Id = row.Id,
                        Deep = row.Deep,
                        ParentId = row.ParentId,
                        Url = row.Url
                    });
            }
            return lst;
        }

        public void SaveChange(long companyId, List<JobFindNew> lstAdded, List<JobFindNew> lstDelete)
        {
            
        }
    }
}