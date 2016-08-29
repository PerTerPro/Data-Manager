using QT.Entities.Data;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QT.Moduls.Crawler
{
    public partial class FrmViewLogAllCompany : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(FrmViewLogAllCompany));
        Dictionary<string, FrmViewLog> dicViewLog = new Dictionary<string, FrmViewLog>();
        private IConnection connectionMQ;
        private bool IsPaused = false;
        public FrmViewLogAllCompany()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                this.IsPaused = false;
                if (connectionMQ == null) connectionMQ = RabbitMQCreator.CreateConnection();
                string queueLog = txtQueueLog.Text;
                string companyFixName = textBox1.Text;
                this.threadRun = new Thread(() => StartTrack(queueLog, companyFixName));
                threadRun.Start();

                this.button1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SetStateRun();
            }
        }

        private void SetStateRun ()
        {
            this.Invoke(new Action(() =>
            {
                if (this.IsPaused)
                {
                    btnRun.Text = "Run";
                }
                else
                {
                    btnRun.Text = "Stop";
                }
            }));
        }

        private void StartTrack(string queueLog, string fixName)
        {
            while (true)
            {
                try
                {
                    var channel = connectionMQ.CreateModel();
                    channel.BasicQos(0, 1, false);
                    QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);
                    String consumerTag = channel.BasicConsume(queueLog, false, consumer);
                    while (true)
                    {
                        while(this.IsPaused)
                        {
                            Thread.Sleep(1000);
                            
                        }
                   
                    }
                }
                catch (ThreadAbortException exThread)
                {
                    break;
                }
                catch (Exception ex)
                {
                    log.ErrorFormat(ex.Message);
                    Thread.Sleep(1000);
                }
            }
        }
        private void HandleJob(byte[] body, string fixName)
        {
            QT.Entities.Data.LogTask log = Websosanh.Core.Common.BAL.ProtobufTool.DeSerialize<LogTask>(body);

            if (fixName == "") log.Company = "ALL";
            if (fixName != "" && !Regex.IsMatch(log.Company, fixName)) return;

            this.Invoke(new Action(() =>
            {
                try
                {
                    //Nhận 1 tin nhắn.
                    string str = log.Company;
                    if (!this.dicViewLog.ContainsKey(str))
                    {
                        FrmViewLog frmViewLog = new FrmViewLog();
                        frmViewLog.Text = str;
                        frmViewLog.MdiParent = this;
                        this.dicViewLog.Add(str, frmViewLog);
                    }
                    this.dicViewLog[str].ShowMessage(log);
                    this.dicViewLog[str].Show();
                }
                catch (Exception ex)
                {

                }
            }));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                this.connectionMQ.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmViewLogAllCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadRun != null && threadRun.IsAlive) this.threadRun.Abort();
            if (this.connectionMQ != null && this.connectionMQ.IsOpen) this.connectionMQ.Close();
        }

        public bool IsStarted = false;
        private Thread threadRun;

        private void button1_Click(object sender, EventArgs e)
        {
            this.IsPaused = !this.IsPaused;
        }
    }
}