using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Websosanh.Core.Drivers.Redis;

namespace QT.Moduls.ProductID
{
    public partial class frmAddMerchantProduct : Form
    {
        private long _idCompany = 0;
        private QT.Entities.Company _company;
        private RedisServer _productMapRedisServer;

        //#region User/Pass FTP Server
        //private string hostIP = "ftp://42.112.17.186";
        //private string userFdisk = "userFdisk";
        //private string passFdisk = "admin2015";
        //private string userGdisk = "userGdisk";
        //private string passGdisk = "admin2015";
        //private string userHdisk = "userHdisk";
        //private string passHdisk = "admin2015";
        //#endregion
        public frmAddMerchantProduct(long idcompany)
        {
            InitializeComponent();
            _idCompany = idcompany;
            var productMapRedisServerName = ConfigurationManager.AppSettings["redisProductMap"];
            _productMapRedisServer = RedisManager.GetRedisServer(productMapRedisServerName);
        }

        private void frmAddMerchantProduct_Load(object sender, EventArgs e)
        {
            this.classificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            InitData();
        }
        private void InitData()
        {
            _company = new QT.Entities.Company(_idCompany);
            // TODO: This line of code loads data into the 'dBProperties.Classification' table. You can move, or remove it, as needed.
            this.classificationTableAdapter.FillByCompanyID(this.dBProperties.Classification, _company.ID);
            //productBindingSource.AddNew();
            this.companyTextEdit.Text = _company.ID.ToString();
            if (_company.Status == QT.Entities.Common.CompanyStatus.WEB_NOMERCHANT)
            {
                detailUrlTextEdit.Properties.ReadOnly = true;
            }
        }
        private void nameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.summaryTextEdit.Text = nameTextEdit.Text;
            this.nameFTTextEdit.Text = QT.Entities.Common.UnicodeToKoDauFulltext(nameTextEdit.Text).ToString();
            this.hashNameTextEdit.Text = QT.Entities.Common.GetHashNameProduct(_company.Domain, nameTextEdit.Text).ToString();

            //Name Image
            NameImagetextEdit.Text = QT.Entities.Common.UnicodeToKoDauAndGach(nameTextEdit.Text);
            if (_company.Status == QT.Entities.Common.CompanyStatus.WEB_NOMERCHANT)
            {
                long productid = 0;
                var idredis = _productMapRedisServer.IncreaseBy("WSS_MERCHANT_PRODUCT_ID", 1000000777);

                detailUrlTextEdit.Text = QT.Entities.Common.GetDetailUrlProductNomerchant(_company.Domain.Replace(".websosanh.vn", ""), nameTextEdit.Text, idredis, out productid);
                iDTextBox.Text = productid.ToString();
            }
        }

        // thêm mới 1 classification
        private void AddNewClassificationButton_Click(object sender, EventArgs e)
        {
            var frmAdd = new frmAddNewClassification(_company.ID);
            frmAdd.f5 += new frmAddNewClassification.F5(loadData);
            frmAdd.ShowDialog();
        }
        private void loadData(long idclass)
        {
            this.classificationTableAdapter.FillByCompanyID(this.dBProperties.Classification, _company.ID);
            classificationIDSearchLookUpEdit.EditValue = idclass;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.lastUpdateDateEdit.EditValue = DateTime.Now;
            this.Validate();
            this.productBindingSource.EndEdit();
            if (nameTextEdit.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được để trống!");
                nameTextEdit.Focus();
            }
            else
            {
                long id = QT.Entities.Common.Obj2Int64(iDTextBox.Text);
                if (id != 0)
                {
                    long classificationId = 0;
                    long.TryParse(classificationIDSearchLookUpEdit.EditValue.ToString(), out classificationId);
                    if (classificationId == 0)
                    {
                        MessageBox.Show("Chọn Classification! Không được để trống");
                    }
                    else
                    {
                        int price = int.Parse(priceSpinEdit.Text);
                        int warranty = int.Parse(warrantySpinEdit.Text);
                        short status = short.Parse(statusSpinEdit.EditValue.ToString());
                        long company = QT.Entities.Common.Obj2Int64(companyTextEdit.Text);
                        long hashname = QT.Entities.Common.Obj2Int64(hashNameTextEdit.Text);
                        int i = this.productTableAdapter.Insert(id, classificationId, price, warranty, status, company, DateTime.Now, 0, promotionTextEdit.Text, summaryTextEdit.Text, productContentTextEdit.Text, nameTextEdit.Text, detailUrlTextEdit.Text, imageUrlsTextEdit.Text, nameFTTextEdit.Text, validCheckEdit.Checked, null, null, true, hashname, imagePathTextEdit.Text, null, null, 0, null, null, null, 0, 0);
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm sản phẩm thành công!");
                            SaveButton.Enabled = false;
                        }
                        else
                            MessageBox.Show("Xảy ra lỗi! Vui lòng liên hệ a Hải đẹp trai phòng Code :))))) ");
                    }
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi! Vui lòng liên hệ a Hải đẹp trai phòng Code :))))) ");
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChoseButton_Click(object sender, EventArgs e)
        {
            openFileDialogImage.InitialDirectory = "C:\\";
            openFileDialogImage.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            openFileDialogImage.FilterIndex = 2;
            openFileDialogImage.RestoreDirectory = true;
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                textEditImagePathLocal.Text = openFileDialogImage.FileName;
                //pictureBoxProduct.Image = Image.FromFile(openFileDialogImage.FileName);
            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditImagePathLocal.Text))
            {
                MessageBox.Show("Vui lòng chọn ảnh !");
            }
            else if (string.IsNullOrEmpty(NameImagetextEdit.Text))
            {
                MessageBox.Show("Nhập tên sản phẩm trước khi upload ảnh!");
                nameTextEdit.Focus();
            }
            else
            {
                string imagepath = string.Empty;
                imagepath = Common.UploadImageProductStore(nameTextEdit.Text, _company.Domain, imageUrlsTextEdit.Text);
                if (imagepath != "")
                    labelControlMessage.Text = "Upload Image Success!";
                else
                    labelControlMessage.Text = "Upload Image Fails!";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang upload ảnh!");
            if (!string.IsNullOrEmpty(imageUrlsTextEdit.Text))
            {
                if (string.IsNullOrEmpty(NameImagetextEdit.Text))
                {
                    MessageBox.Show("Nhập tên sản phẩm trước khi upload ảnh!");
                    nameTextEdit.Focus();
                }
                else
                {
                    string imagepath = string.Empty;
                    imagepath = Common.UploadImageProductStore(nameTextEdit.Text, _company.Domain, imageUrlsTextEdit.Text);
                    if (imagepath != "")
                        labelControlMessage.Text = "Upload Image Success!";
                    else
                        labelControlMessage.Text = "Upload Image Fails!";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL ảnh vào!");
                imageUrlsTextEdit.Focus();
            }
            Wait.Close();
        }

        private void detailUrlTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (_company.Status != QT.Entities.Common.CompanyStatus.WEB_NOMERCHANT)
            {
                this.iDTextBox.Text = QT.Entities.Common.GetIDProduct(detailUrlTextEdit.Text).ToString();
            }
        }
    }
}
