using QT.Entities;
using QT.Entities.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FrmUpLoadListLogo : Form
    {
        private RabbitMQServer _rabbitMqServer;
        private JobClient _jobClientDownloadImage;
        public FrmUpLoadListLogo()
        {
            InitializeComponent();
            companyTableAdapter.Connection.ConnectionString = ConnectionCommon.ConnectionWebsosanh;
            company_AutoGenerateLogoTableAdapter.Connection.ConnectionString = ConnectionCommon.ConnectionWebsosanh;
            _rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigImages.RabbitMqServerName);
            _jobClientDownloadImage = new JobClient("Merchant", GroupType.Topic, "Update", true, _rabbitMqServer);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            int success = 0;
            int fail = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileNames.Length > 0)
                {
                    lbCount.Text = openFileDialog1.FileNames.Length.ToString();
                    foreach (var item in openFileDialog1.FileNames)
                    {
                        try
                        {
                            string idImboNew = Common.UploadImageProductWithImboServerByHand(item, ConfigImbo.PublicKey, ConfigImbo.PrivateKey, "logo", ConfigImbo.Host, ConfigImbo.Port);
                            string fileName = Path.GetFileName(item);
                            if (!string.IsNullOrEmpty(idImboNew))
                            {
                                string domain = fileName.Split('.')[0];
                                var idCompany = Common.GetIDCompany(domain.Replace("_", "."));
                                companyTableAdapter.UpdateLogoImageId(idImboNew, idCompany);
                                //company_AutoGenerateLogoTableAdapter.Insert(idCompany, DateTime.Now); ()
                                SendMessageUpdateCompany(idCompany);
                                success++;
                                rbSuccess.AppendText(string.Format("{0} success with IDimbo: {1}!", fileName, idImboNew) + System.Environment.NewLine);
                            }
                            else
                            {
                                rbFail.AppendText(string.Format("{0} fails with IDimbo: {1}!", fileName, idImboNew) + System.Environment.NewLine);
                                fail++;
                            }
                        }
                        catch (Exception ex)
                        {
                            rbError.AppendText(item + System.Environment.NewLine + ex.ToString() + System.Environment.NewLine);
                            fail++;
                        }
                    }
                    lbSuccess.Text = success.ToString();
                    lbFail.Text = fail.ToString();
                    MessageBox.Show("Upload finished!");
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
                rbError.AppendText(string.Format("Push message error with IdCompany: {0}",idCompany) + System.Environment.NewLine + ex.ToString() + System.Environment.NewLine);
            }
        }
        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBWss);

        }

        private void FrmUpLoadListLogo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBWss.Company_AutoGenerateLogo' table. You can move, or remove it, as needed.
            //this.company_AutoGenerateLogoTableAdapter.Fill(this.dBWss.Company_AutoGenerateLogo);
            // TODO: This line of code loads data into the 'dBWss.Company' table. You can move, or remove it, as needed.
            //is.companyTableAdapter.Fill(this.dBWss.Company);

        }
    }
}
