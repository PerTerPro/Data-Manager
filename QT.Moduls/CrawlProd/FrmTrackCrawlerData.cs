using QT.Entities.Data;
using RabbitMQ.Client;
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

namespace QT.Moduls.CrawlProd
{
    public partial class FrmTrackCrawlerData : Form
    {
        private IConnection connectionMQ;

        public FrmTrackCrawlerData()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread threadRun = new Thread(() => StartTrack());
            threadRun.Start();
        }

        private void StartTrack()
        {
            while (connectionMQ.IsOpen == true)
            {
                try
                {
                    var channel = connectionMQ.CreateModel();
                    QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);
                    String consumerTag = channel.BasicConsume("crawler_product_log", false, consumer);
                    while (true)
                    {
                   
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void HandleJob(byte[] body)
        {
            QT.Entities.Data.LogTask log = Websosanh.Core.Common.BAL.ProtobufTool.DeSerialize<LogTask>(body);
            this.Invoke(new Action(() =>
            {
                //Nhận 1 tin nhắn.
                string str = log.EventLog;
                switch (str)
                {
                    case "eventProcessLink":
                        {
                            if (txteventProcessLink.TextLength > 100000) txteventProcessLink.Text = "";
                            txteventProcessLink.AppendText(string.Format("\n{0}:{1}", log.Consumer, log.Message));
                        } break;
                    case "eventWhenGetProductLink":
                        {
                            if (txteventWhenGetProductLink.TextLength > 100000) txteventWhenGetProductLink.Text = "";
                            txteventWhenGetProductLink.AppendText(string.Format("\n{0}:{1}", log.Consumer, log.Message));
                        } break;
                    case "eventWhenAddQueue":
                        {
                            if (txteventWhenAddQueue.TextLength > 100000) txteventWhenAddQueue.Text = "";
                            txteventWhenAddQueue.AppendText(string.Format("\n{0}:{1}", log.Consumer, log.Message));
                        } break;
                    default:
                        {
                            if (txtOtherMss.TextLength > 100000) txtOtherMss.Text = "";
                            txtOtherMss.AppendText(string.Format("\n{0}:{1}:{2}", log.Consumer, log.Message, log.EventLog));
                        } break;

                }
            }));
        }

        private void FrmViewLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.connectionMQ.IsOpen == true)
                this.connectionMQ.Close();
        }

        private void FrmViewLog_Load(object sender, EventArgs e)
        {
            this.connectionMQ = QT.Entities.Data.RabbitMQCreator.CreateConnection();
        }
    }
}
