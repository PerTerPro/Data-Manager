using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.JobServer;

namespace QT.Moduls.KeywordSuggest
{
    public partial class FrmImportKeywordSuggest : Form
    {
        private Websosanh.Core.Drivers.RabbitMQ.RabbitMQServer rabbitMQServer;
        public FrmImportKeywordSuggest()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                rabbitMQServer = Websosanh.Core.Drivers.RabbitMQ.RabbitMQManager.GetRabbitMQServer("rabbitMQKeywordSuggest");
                JobClient updateProductJobClient_PushCompany = new JobClient("UpdateKeywordSuggest", GroupType.Topic, "UpdateKeywordSuggest.Keyword", true, rabbitMQServer);
                string[] keywords = this.richTextBox1.Text.Split(new char[] { '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (keywords.Length > 0)
                {
                    SaveLastSource(keywords);
                    foreach (var keyword in keywords)
                    {
                        while (true)
                        {
                            try
                            {
                                updateProductJobClient_PushCompany.PublishJob(new Job()
                                {

                                    Data = new QT.Entities.CrawlerProduct.RabbitMQ.MsJobKeywordSuggest()
                                    {
                                        Keyword = keyword.Trim()
                                    }.GetArByte()
                                    ,
                                    Type = 0

                                }, 0);
                                break;
                            }
                            catch (Exception ex)
                            {
                                Thread.Sleep(1000);
                            }
                        }
                    }
                }
                MessageBox.Show(string.Format("Pushed {0} keywords", keywords.Length.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SaveLastSource(string[] keywords)
        {
            try
            {
                string session = Guid.NewGuid().ToString();
                SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
                sqlDb.RunQuery("delete from Keyword_Volume_Source", CommandType.Text, null);
                string queryPattern = "insert into Keyword_Volume_Source (keyword, session, DatePush) values {0}";
                string patternValue = "(N'{0}', N'{1}', '{2}')";
                List<string> lst = new List<string>();
                foreach (var item in keywords)
                {
                    lst.Add(string.Format(patternValue, item, session, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                }
                string lastQuery = string.Format(queryPattern, string.Join(",", lst));
                sqlDb.RunQuery(lastQuery, CommandType.Text, null);
                return;
            }
            catch (Exception ex01)
            {
                MessageBox.Show(ex01.Message);
            }
        }
    }
}
