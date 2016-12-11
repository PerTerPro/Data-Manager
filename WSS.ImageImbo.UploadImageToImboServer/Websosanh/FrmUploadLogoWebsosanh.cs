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
using WSS.ImageServer;

namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    public partial class FrmUploadLogoWebsosanh : Form
    {
        private string _domainLogo = "";
        public FrmUploadLogoWebsosanh()
        {
            InitializeComponent();
            _domainLogo = ConfigurationSettings.AppSettings["DomainLogo"];
        }

        private void FrmUploadLogoWebsosanh_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.Connection.ConnectionString = ConnectionCommon.ConnectionWebsosanh;
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxNew.Image = Image.FromFile(openFileDialog1.FileName);
                    
                    string idImboOld = logoImageIdTextEdit.Text;
                    string idImboNew = ImboImageService.PushFromFile(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, openFileDialog1.FileName, "logo", ConfigImbo.Host, ConfigImbo.Port);
                    if (!string.IsNullOrEmpty(idImboNew))
                    {
                        logoImageIdTextEdit.Text = idImboNew;
                        if (!string.IsNullOrEmpty(idImboOld))
                        {
                            ImboImageService.DelteImage(ConfigImbo.PublicKey, ConfigImbo.PrivateKey, idImboOld, "logo", ConfigImbo.Host, ConfigImbo.Port);
                        }
                        companyTableAdapter.UpdateLogoImageId(idImboNew, Convert.ToInt64(iDTextEdit.Text));
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
