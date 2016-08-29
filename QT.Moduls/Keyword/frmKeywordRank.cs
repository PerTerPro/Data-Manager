using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.Keyword
{
    public partial class frmKeywordRank : Form
    {
        RabbitMQServer rabbitMQServer;
        JobClient jobClient;
        string rabbitMQServerName = "";
        string rankKeywordGroupName = "";
        string checkRankKeywordJobName = "";
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmKeywordRank));
        public frmKeywordRank()
        {
            InitializeComponent();
            Init();
        }
        private void Init() {
            rabbitMQServerName = ConfigurationSettings.AppSettings["rabbitMQServerName"];
            rankKeywordGroupName = ConfigurationSettings.AppSettings["rankKeywordGroupName"];
            checkRankKeywordJobName = ConfigurationSettings.AppSettings["checkRankKeywordJobName"];
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            jobClient = new JobClient(rankKeywordGroupName, GroupType.Topic, checkRankKeywordJobName,true, rabbitMQServer);
        }

        private void btnPushMessage_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text != "")
            {

                btnPushMessage.Visible = false;
                if (!PushMessage(txtKeyword.Text)) MessageBox.Show("Push message Fails!");
                btnPushMessage.Visible = true;
            }
            else
            {
                if (txtFile.Text != "")
                {
                    string[] lines = System.IO.File.ReadAllLines(txtFile.Text);
                    foreach (var item in lines)
                    {
                        PushMessage(item); 
                    }
                }
                else
                {
                    MessageBox.Show("Nhập từ khóa");
                    txtKeyword.Focus();
                }
            }
        }

        public bool PushMessage(string keyword)
        {
            bool result = false;
            try
            {
                if (jobClient != null)
                {
                    Job job = new Job();
                    job.Data = System.Text.Encoding.UTF8.GetBytes(keyword);
                    jobClient.PublishJob(job);
                    result = true;
                }
                else
                    Log.Error("JobClient null!!!");
            }
            catch (Exception ex)
            {
                Log.Error("Push Message Error:", ex);
            }
            return result;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult result = openfile.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = openfile.FileName;
            }
        }
    }
}
