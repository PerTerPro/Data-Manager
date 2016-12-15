using QT.Entities;
using QT.Entities.Images;
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
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    public partial class FrmPushMessageDownloadImageCompany : Form
    {
        public FrmPushMessageDownloadImageCompany()
        {
            InitializeComponent();
        }

        private void btnPushMessage_Click(object sender, EventArgs e)
        {
            PushListIdCompanyToServiceDownloadImage();
        }
        private void PushListIdCompanyToServiceDownloadImage()
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
            var jobClientDownloadImage = new JobClient(ConfigImages.ImboExchangeImages, GroupType.Topic, ConfigImages.ImboRoutingKeyDownloadImageCompany, true, rabbitMqServer);

            var listIdCompany = rbListIdCompany.Text.Split('\n');
            foreach (var item in listIdCompany)
            {
                long idcompany = Common.Obj2Int64(item);
                try
                {
                    var job = new Job { Data = BitConverter.GetBytes(idcompany), Type = (int)TypeJobWithRabbitMQ.Company };
                    jobClientDownloadImage.PublishJob(job);
                    rbMessage.AppendText(string.Format("{0} success", idcompany) + System.Environment.NewLine);
                }
                catch (Exception ex)
                {
                    rbMessage.AppendText(string.Format("{0} fail {1}", idcompany, ex) + System.Environment.NewLine);
                }
            }
            rabbitMqServer.Stop();
        }
    }
}
