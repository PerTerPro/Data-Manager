using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.JobServer;

namespace QT.Moduls.KeywordSuggest
{
    public partial class FrmPushTopKeyword : Form
    {
        public FrmPushTopKeyword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=183.91.14.82;Initial Catalog=News;Persist Security Info=True;User ID=wss_news;Password=@F4sJ=l9/ryJt9MT;";
            SqlDb sqlDb = new SqlDb(connection);
            DataTable tblTOp = sqlDb.GetTblData(@"SELECT TOP 1000 [ID]
      ,[CatID]
      ,[CatName]
      ,[Keyword]
      ,[Click]
      ,[LastUpdate], Sort
  FROM [News].[dbo].[Tracking_Keyword_Cat]
  WHERE Sort < 20",CommandType.Text,new System.Data.SqlClient.SqlParameter[]{});
            this.gridControl1.DataSource=tblTOp;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            DataTable tbl = this.gridControl1.DataSource as DataTable;
            Dictionary<string, bool> dicKeyword = new Dictionary<string,bool>();
            foreach(DataRow rowInfo in tbl.Rows)
            {
                string keyword = rowInfo["Keyword"].ToString();
                if (!dicKeyword.ContainsKey(keyword)) dicKeyword.Add(keyword, true);
            }


            try
            {
                var rabbitMQServer = Websosanh.Core.Drivers.RabbitMQ.RabbitMQManager.GetRabbitMQServer("rabbitMQKeywordSuggest");
                JobClient updateProductJobClient_PushCompany = new JobClient("UpdateKeywordBatch", GroupType.Topic, "UpdateKeywordBatch.FindSuggest", true, rabbitMQServer);
                foreach (var keyword in dicKeyword)
                {
                    updateProductJobClient_PushCompany.PublishJob(new Job()
                    {
                        Data = new QT.Entities.CrawlerProduct.RabbitMQ.MsJobKeywordSuggest()
                        {
                            Keyword = keyword.Key
                        }.GetArByte()
                        ,
                        Type = 0
                    }, 0);
                }
                MessageBox.Show(string.Format("Pushed {0} keywords", dicKeyword.Count.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
