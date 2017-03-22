using QT.Entities;
using QT.Entities.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;
using WSS.ImageServer;

namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    public partial class FrmUploadLogoWebsosanh : Form
    {
        private string _domainLogo = "";
        private RabbitMQServer _rabbitMqServer;
        private JobClient _jobClientDownloadImage;
        public FrmUploadLogoWebsosanh()
        {
            InitializeComponent();
            _domainLogo = ConfigurationSettings.AppSettings["DomainLogo"];
        }

        private void FrmUploadLogoWebsosanh_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.Connection.ConnectionString = ConnectionCommon.ConnectionWebsosanh;
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
            _jobClientDownloadImage = new JobClient("Merchant", GroupType.Topic, "Update", true, _rabbitMqServer);
        }

        private void logoImageIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(logoImageIdTextEdit.Text) && logoImageIdTextEdit.Text.Length == 12)
            {
                var linkLogo = _domainLogo + logoImageIdTextEdit.Text + ".png";
                pictureBoxwebsosanh.ImageLocation = linkLogo;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    string idImboOld = logoImageIdTextEdit.Text;
                    openFileDialog1.Dispose();
                    string idImboNew = Common.UploadImageProductWithImboServerByHand(path, ConfigImbo.PublicKey, ConfigImbo.PrivateKey, "logo", ConfigImbo.Host, ConfigImbo.Port);
                    if (!string.IsNullOrEmpty(idImboNew))
                    {
                        logoImageIdTextEdit.Text = idImboNew;
                        //if (!string.IsNullOrEmpty(idImboOld))
                        //{
                        //    new WSS.ImageImbo.Lib.ImboService().DeleteImg(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, idImboOld, "logo", ConfigImbo.Host, ConfigImbo.Port);
                        //}
                        var idCompany = Common.Obj2Int64(iDTextEdit.Text);
                        companyTableAdapter.UpdateLogoImageId(idImboNew, idCompany);
                        SendMessageUpdateCompany(idCompany);
                        lbMessage.Text = "Upload success!";
                    }
                    else
                        lbMessage.Text = "Upload fails! Id imbo null";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    lbMessage.Text = "Upload fails! " + ex.Message;
                }
            }
        }
        private void SendMessageUpdateCompany(long idCompany)
        {
            try
            {
                var job = new Job { Data = BitConverter.GetBytes(idCompany), Type = (int)TypeJobWithRabbitMQ.Company };
                _jobClientDownloadImage.PublishJob(job);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string domain = "%" + txtDomain.Text + "%";
            try
            {
                companyTableAdapter.FillBy_LikeDomain(dBWss.Company, domain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
