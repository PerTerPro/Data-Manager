using GABIZ.Base.HtmlAgilityPack;
using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.CrawlerProduct
{
    public class WorkerCrawlerReview
    {
        QT.Entities.Company company = new QT.Entities.Company();
        QT.Entities.Configuration configuration = new Entities.Configuration();
        ProductAdapter productAdapter = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
        Queue<JobCrawlerReview> queuCrawler = new Queue<JobCrawlerReview>();

        public WorkerCrawlerReview (long companyID)
        {
            
        }
        public void Start ()
        {
            LoadQueue();
        }

        private void LoadQueue()
        {
            DataTable tblProduct = this.productAdapter.GetProductValidToFindDesc(company.ID);
            foreach(DataRow rowPt in tblProduct.Rows)
            {
                this.queuCrawler.Enqueue(new JobCrawlerReview()
                {
                    id = Convert.ToInt64(rowPt["id"]),
                    url = Convert.ToString(rowPt["url"])
                });
            }

            while (queuCrawler.Count>0)
            {
                var jobCraweler = this.queuCrawler.Dequeue();
                string html = GABIZ.Base.HtmlUrl.HTMLTransmitter.getHTML(jobCraweler.url, 45, 2);
                if (!string.IsNullOrEmpty(html))
                {
                    HtmlDocument document = new HtmlDocument();
                    document.Load(html);
                    List<string> lstReviewXpath = new List<string>() ;
                    List<CommentProduct> lstComment = new List<CommentProduct>();
                }
            }
        }

        public void UpdateEnd ()
        {

        }

        public void UpdateStart ()
        {

        }
    }
}
