using DevExpress.XtraTab;
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


namespace QT.Moduls.Crawler
{
    public partial class FrmViewLog : Form
    {
        Dictionary<string, XtraTabPage> lstFrmLogForm = new Dictionary<string, XtraTabPage>();
        private IConnection connectionMQ;

        public FrmViewLog()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }



        private void HandleJob(byte[] body)
        {
            QT.Entities.Data.LogTask log = Websosanh.Core.Common.BAL.ProtobufTool.DeSerialize<LogTask>(body);
            this.Invoke(new Action(() =>
            {
                try
                {
                    //Nhận 1 tin nhắn.
                    string str = log.EventLog;

                    string nameOfTab = log.EventLog;
                    if (!this.lstFrmLogForm.ContainsKey(nameOfTab))
                    {
                        XtraTabPage pageNew = new XtraTabPage();
                        pageNew.Text = nameOfTab;
                        this.xtraTabContorl.TabPages.Add(pageNew);
                        var ucLogD = (new ucLog());
                        pageNew.Controls.Add(ucLogD);
                        ucLogD.Dock = DockStyle.Fill;
                        lstFrmLogForm.Add(nameOfTab, pageNew);
                    }
                    (this.lstFrmLogForm[nameOfTab].Controls[0] as ucLog).AddLog(log.Message);
                }
                catch (Exception ex)
                {

                }

            }));
        }

        private void FrmViewLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            if (this.connectionMQ.IsOpen == true)
                this.connectionMQ.Close();
        }

        private void FrmViewLog_Load(object sender, EventArgs e)
        {
            this.connectionMQ = QT.Entities.Data.RabbitMQCreator.CreateConnection();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowMessage(LogTask log)
        {
            this.Invoke(new Action(() =>
            {
                try
                {
                    string str = log.EventLog;
                    string nameOfTab = log.EventLog;
                    if (!this.lstFrmLogForm.ContainsKey(nameOfTab))
                    {
                        XtraTabPage pageNew = new XtraTabPage();
                        pageNew.Text = nameOfTab;
                        this.xtraTabContorl.TabPages.Add(pageNew);
                        var ucLogD = (new ucLog());
                        pageNew.Controls.Add(ucLogD);
                        ucLogD.Dock = DockStyle.Fill;
                        lstFrmLogForm.Add(nameOfTab, pageNew);
                    }
                    (this.lstFrmLogForm[nameOfTab].Controls[0] as ucLog).AddLog(log.Message);
                }
                catch (Exception ex)
                {

                }

            }));
        }
    }
}
