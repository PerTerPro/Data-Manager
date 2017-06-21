using QT.Entities.Data;
using QT.Entities.Model.SaleNews;
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

namespace QT.Moduls.CrawlSale
{
    public partial class FrmPushJobReload : Form
    {
        private bool IsClosed = false;

        public FrmPushJobReload()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Thread threadRun = new Thread(() =>
            // {
            //     string strQueueName = txtQueueName.Text;
            //     int iLimitJob = 10;
            //     while (!this.IsClosed)
            //     {
            //         this.WriteLog("Begin push data!");
            //         MongoDbRaoVat mongoDb = new MongoDbRaoVat();
            //         var connectMQ1 = RabbitMQCreator.CreateConnection();
            //         var channel = connectMQ1.CreateModel();
            //         var resultMQ = channel.QueueDeclare(strQueueName, true, false, false, null);
            //         var listReload = mongoDb.GetProductNeedReload(10000).Result;
            //         uint iCurrentMSS = resultMQ.MessageCount;
            //         if (iCurrentMSS < iLimitJob)
            //         {
            //             foreach (var item in listReload)
            //             {
            //                 var taskReload = new TaskMQ()
            //                 {
            //                     Url = item["url"].AsString,
            //                     ConfigID = item["source_id"].AsInt32,
            //                     Deep = 0,
            //                     Session = 0,
            //                     TypeCrawler = 2,
            //                     IsExtraction = false,
            //                     IsProduct = true
            //                 };
            //                 var a = Websosanh.Core.Common.BAL.ProtobufTool.Serialize(taskReload);
            //                 channel.QueueDeclare(strQueueName, true, false, false, null);
            //                 channel.BasicPublish("", strQueueName, null, a);
            //             }
            //             WriteLog(string.Format("CurrentMss:{1} Pushed {0} job", listReload.Count,iCurrentMSS));
            //         }
            //         else
            //         {
            //             WriteLog(string.Format("Over message:{0}>{1}", iCurrentMSS, iLimitJob.ToString()));
            //         }
            //         channel.Close();
            //         connectMQ1.Close();

            //         Thread.Sleep(10000);
            //     }
            // });
            //threadRun.Start();
        }

        private void FrmPushJobReload_Load(object sender, EventArgs e)
        {
           
        }

        public void WriteLog(string data)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    if (this.report.TextLength > 1000000) this.report.Clear();
                    this.report.AppendText("\n" + data);
                }));
            }
            catch (Exception ex)
            {
            }
        }

        private void FrmPushJobReload_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.IsClosed = true;
        }
    }
}
