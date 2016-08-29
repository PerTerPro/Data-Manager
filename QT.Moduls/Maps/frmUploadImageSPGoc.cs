using QT.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.Maps
{
    public partial class frmUploadImageSPGoc : Form
    {
        private long _productId;
        private string _nameProduct;
        private string _mapcategoryProduct;
        public frmUploadImageSPGoc(long productID, string nameproduct)
        {
            InitializeComponent();
            _productId = productID;
            IDtextEdit.Text = productID.ToString();
            _nameProduct = nameproduct;
            NametextEdit.Text = nameproduct;
            productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            InitData();
        }
        private void InitData()
        {
            try
            {
                DBPManTableAdapters.ProductTableAdapter _productTableAdapter = new DBPManTableAdapters.ProductTableAdapter();
                _productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                DBPMan.ProductDataTable productTable = new DBPMan.ProductDataTable();
                _productTableAdapter.FillBy_ID(productTable, _productId);
                if (productTable.Rows.Count != 0)
                {
                    string imagepath = productTable.Rows[0]["ImagePath"].ToString();
                    #region Kiểm tran ImagePath
                    //nếu có ImagePath thì hiển thị ảnh
                    #region Có ảnh
                    if (!string.IsNullOrEmpty(imagepath))
                    {
                        string imgurl = "http://img.websosanh.vn/" + imagepath;
                        pictureBoxProduct.ImageLocation = imgurl;
                        checkEditProduct.Checked = true;
                    }
                    #endregion
                    else
                        {
                            #region Chưa có ảnh - kiểm tra ImageUrls -> Thực hiện download ảnh -> Tự upload ảnh đại diện
                            string imageurls = productTable.Rows[0]["ImageUrls"].ToString();
                            if (!string.IsNullOrEmpty(imageurls))
                            {
                                if (Common.UploadImageSPGoc(_productId, _nameProduct, imageurls))
                                    labelControlProduct.Text = "Upload success!";
                                else
                                    labelControlProduct.Text = "Upload fails!"; 
                            }
                            else
                                labelControlProduct.Text = "ImageUrls ko có. Upload ảnh trực tiếp!";
                            #endregion
                        }
                    #region Lấy MapCategory của Product để tạo thư mục
                    int categoryId = QT.Entities.Common.Obj2Int(productTable.Rows[0]["CategoryID"].ToString());
                    _mapcategoryProduct = GetFilterCategory(categoryId);
                    #endregion
                }
                else
                    richTextBox1.Text = "Xảy ra lỗi, không tìm thấy sản phẩm trong Database!";
                #endregion
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }

        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            QT.Entities.Wait.Show("Upload Ảnh...");
            #region Upload ảnh đại diện sản phẩm
            string filename = QT.Entities.Common.UnicodeToKoDauAndGach(_nameProduct);
            if (!string.IsNullOrEmpty(pathTextEditProduct.Text))
            {
                string tempf = filename.Replace("-", "");
                string folder = tempf.Substring(0, 3);
                if (folder == "bin") folder = "bin1";
                if (folder == "con") folder = "con1";
                if (filename.Length > 100)
                {
                    filename = filename.Substring(0, 99);
                }
                string newpath = folder + "/" + filename + ".jpg";
                string pathLocal = pathTextEditProduct.Text;
                if (QT.Entities.FTP.CreateDirectory(SPGocImageFTP.HostIP, SPGocImageFTP.UserAccount, SPGocImageFTP.Password, folder))
                {
                    if (QT.Entities.FTP.UploadFile(SPGocImageFTP.HostIP, SPGocImageFTP.UserAccount, SPGocImageFTP.Password, newpath, pathLocal))
                    {
                        labelControlProduct.Text = "Upload success!";
                        #region Cập nhật lại ImagePath trong Bảng Product
                        string imagepathnew = "Store/images/" + newpath;
                        pictureBoxProduct.ImageLocation = "http://img.websosanh.vn/" + imagepathnew;
                        try
                        {
                            productTableAdapter.UpdateImagePath(imagepathnew, _productId);
                        }
                        catch (Exception ex)
                        {
                            richTextBox1.Text = ex.Message;
                        }
                        #endregion
                        #region Kiểm tra ảnh Thumb trên img.websosanh.net
                        //Nếu đã có ảnh Thum thì xóa ảnh đi.
                        string remotefile = folder + "/" + filename + SPGocImageThumbFTP.SizeThumb+ ".jpg" ;
                        if (QT.Entities.FTP.CheckFileExists(SPGocImageThumbFTP.HostIP, SPGocImageThumbFTP.UserAccount, SPGocImageThumbFTP.Password, remotefile))
                        {
                            if (!QT.Entities.FTP.DeleteFile(SPGocImageThumbFTP.HostIP, SPGocImageThumbFTP.UserAccount, SPGocImageThumbFTP.Password, remotefile))
                                richTextBox1.Text += "Xóa ảnh Thumb lỗi!";
                        }
                        #endregion
                    }
                    else
                        labelControlProduct.Text = "Upload fails!";
                }
                else
                    {
                        richTextBox1.Text += "Tạo đường dẫn xảy ra lỗi\r\n";
                        labelControlProduct.Text = "Upload fails!";
                    }
            }
            #endregion

            //Sửa: ko cần ảnh slide 16.09.2015
            #region Upload Ảnh Slide sản phẩm
            //string folderimageslide = _mapcategoryProduct;
            //#region Ảnh 1:
            //if (!string.IsNullOrEmpty(pathTextEdit1.Text))
            //{
            //    string filename1 = filename + "1" + ".jpg";
            //    string newpath1 = folderimageslide + "/" + filename1;
            //    string pathLocal1 = pathTextEdit1.Text;
            //    if (QT.Entities.FTP.CreateDirectory(hostIpreview, userftpreview, passwordftpreview, folderimageslide))
            //    {
            //        if (QT.Entities.FTP.UploadFile(hostIpreview, userftpreview, passwordftpreview, newpath1, pathLocal1))
            //        {
            //            string imagepathnew1 = "/Uploads/Store/" + newpath1;
            //            pictureBox1.ImageLocation = "http://review.websosanh.net" + imagepathnew1;
            //            labelControl1.Text = "Upload success!";
            //            if (checkEdit1.Checked && !string.IsNullOrEmpty(IDImagetextEdit1.Text))
            //            {
            //                long idImage1 = QT.Entities.Common.Obj2Int64(IDImagetextEdit1.Text);
            //                try
            //                {
            //                    product_ImageTableAdapter.UpdateImageStore(filename1, imagepathnew1, 1, DateTime.Now, idImage1);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //            }
            //            else
            //                try
            //                {
            //                    product_ImageTableAdapter.Insert(_productId, "", "", filename1, imagepathnew1, 0, 0, 0, "image/jpeg", "", 1, DateTime.Now);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //        }
            //        else
            //            labelControl2.Text = "Upload fails!";
            //    }
            //    else
            //    {
            //        labelControl2.Text = "Upload fails!";
            //        richTextBox1.Text += "Tạo đường dẫn xảy ra lỗi\r\n";
            //    }
            //}
            //#endregion

            //#region Ảnh 2:
            //if (!string.IsNullOrEmpty(pathTextEdit2.Text))
            //{
            //    string filename2 = filename + "2" + ".jpg";
            //    string newpath2 = folderimageslide + "/" + filename2;
            //    string pathLocal2 = pathTextEdit2.Text;
            //    if (QT.Entities.FTP.CreateDirectory(hostIpreview, userftpreview, passwordftpreview, folderimageslide))
            //    {
            //        if (QT.Entities.FTP.UploadFile(hostIpreview, userftpreview, passwordftpreview, newpath2, pathLocal2))
            //        {
            //            string imagepathnew2 = "/Uploads/Store/" + newpath2;
            //            pictureBox2.ImageLocation = "http://review.websosanh.net" + imagepathnew2;
            //            labelControl2.Text = "Upload success!";
            //            if (checkEdit2.Checked && !string.IsNullOrEmpty(IDImagetextEdit2.Text))
            //            {
            //                long idImage2 = QT.Entities.Common.Obj2Int64(IDImagetextEdit2.Text);

            //                try
            //                {
            //                    product_ImageTableAdapter.UpdateImageStore(filename2, imagepathnew2, 2, DateTime.Now, idImage2);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //            }
            //            else
            //                try
            //                {
            //                    product_ImageTableAdapter.Insert(_productId, "", "", filename2, imagepathnew2, 0, 0, 0, "image/jpeg", "", 2, DateTime.Now);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                } 
            //        }
            //        else
            //            labelControl2.Text = "Upload fails!";
            //    }
            //    else
            //        {
            //            labelControl2.Text = "Upload fails!";
            //            richTextBox1.Text += "Tạo đường dẫn xảy ra lỗi\r\n";
            //        }
            //}
            //#endregion

            //#region Ảnh 3:
            //if (!string.IsNullOrEmpty(pathTextEdit3.Text))
            //{
            //    string filename3 = filename + "3" + ".jpg";
            //    string newpath3 = folderimageslide + "/" + filename3;
            //    string pathLocal3 = pathTextEdit3.Text;
            //    if (QT.Entities.FTP.CreateDirectory(hostIpreview, userftpreview, passwordftpreview, folderimageslide))
            //    {
            //        if (QT.Entities.FTP.UploadFile(hostIpreview, userftpreview, passwordftpreview, newpath3, pathLocal3))
            //        {
            //            string imagepathnew3 = "/Uploads/Store/" + newpath3;
            //            pictureBox3.ImageLocation = "http://review.websosanh.net" + imagepathnew3;
            //            labelControl3.Text = "Upload success!";
            //            if (checkEdit3.Checked && !string.IsNullOrEmpty(IDImagetextEdit3.Text))
            //            {
            //                long idImage3 = QT.Entities.Common.Obj2Int64(IDImagetextEdit3.Text);
            //                try
            //                {
            //                    product_ImageTableAdapter.UpdateImageStore(filename3, imagepathnew3, 3, DateTime.Now, idImage3);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //            }
            //            else
            //                try
            //                {
            //                    product_ImageTableAdapter.Insert(_productId, "", "", filename3, imagepathnew3, 0, 0, 0, "image/jpeg", "", 3, DateTime.Now);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //        }
            //        else
            //            labelControl3.Text = "Upload fails!";
            //    }
            //    else
            //        {
            //            labelControl3.Text = "Upload fails!";
            //            richTextBox1.Text += "Tạo đường dẫn xảy ra lỗi\r\n";
            //        }
            //}
            //#endregion

            //#region Ảnh 4:
            //if (!string.IsNullOrEmpty(pathTextEdit4.Text))
            //{
            //    string filename4 = filename + "4" + ".jpg";
            //    string newpath4 = folderimageslide + "/" + filename4;
            //    string pathLocal4 = pathTextEdit4.Text;
            //    if (QT.Entities.FTP.CreateDirectory(hostIpreview, userftpreview, passwordftpreview, folderimageslide))
            //    {
            //        if (QT.Entities.FTP.UploadFile(hostIpreview, userftpreview, passwordftpreview, newpath4, pathLocal4))
            //        {
            //            string imagepathnew4 = "/Uploads/Store/" + newpath4;
            //            pictureBox4.ImageLocation = "http://review.websosanh.net" + imagepathnew4;
            //            labelControl4.Text = "Upload success!";
            //            if (checkEdit4.Checked && !string.IsNullOrEmpty(IDImagetextEdit4.Text))
            //            {
            //                long idImage4 = QT.Entities.Common.Obj2Int64(IDImagetextEdit4.Text);
            //                try
            //                {
            //                    product_ImageTableAdapter.UpdateImageStore(filename4, imagepathnew4, 4, DateTime.Now, idImage4);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //            }
            //            else
            //                try
            //                {
            //                    product_ImageTableAdapter.Insert(_productId, "", "", filename4, imagepathnew4, 0, 0, 0, "image/jpeg", "", 4, DateTime.Now);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //        }
            //        else
            //            labelControl4.Text = "Upload fails!";
            //    }
            //    else
            //        {
            //            richTextBox1.Text += "Tạo đường dẫn xảy ra lỗi\r\n";
            //            labelControl4.Text = "Upload fails!";
            //        }
            //}
            //#endregion

            //#region Ảnh 5:
            //if (!string.IsNullOrEmpty(pathTextEdit5.Text))
            //{
            //    string filename5 = filename + "5" + ".jpg";
            //    string newpath5 = folderimageslide + "/" + filename5;
            //    string pathLocal5 = pathTextEdit5.Text;
            //    if (QT.Entities.FTP.CreateDirectory(hostIpreview, userftpreview, passwordftpreview, folderimageslide))
            //    {
            //        if (QT.Entities.FTP.UploadFile(hostIpreview, userftpreview, passwordftpreview, newpath5, pathLocal5))
            //        {
            //            string imagepathnew5 = "/Uploads/Store/" + newpath5;
            //            pictureBox5.ImageLocation = "http://review.websosanh.net" + imagepathnew5;
            //            labelControl5.Text = "Upload success!";
            //            if (checkEdit5.Checked && !string.IsNullOrEmpty(IDImagetextEdit5.Text))
            //            {
            //                long idImage5 = QT.Entities.Common.Obj2Int64(IDImagetextEdit5.Text);
            //                try
            //                {
            //                    product_ImageTableAdapter.UpdateImageStore(filename5, imagepathnew5, 5, DateTime.Now, idImage5);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //            }
            //            else
            //                try
            //                {
            //                    product_ImageTableAdapter.Insert(_productId, "", "", filename5, imagepathnew5, 0, 0, 0, "image/jpeg", "", 5, DateTime.Now);
            //                }
            //                catch (Exception ex)
            //                {
            //                    richTextBox1.Text += ex.Message;
            //                }
            //        }
            //        else
            //            labelControl5.Text = "Upload fails!";
            //    }
            //    else
            //        {
            //            labelControl5.Text = "Upload fails!";
            //            richTextBox1.Text += "Tạo đường dẫn xảy ra lỗi\r\n";
            //        }
            //}
            //#endregion
            #endregion
            QT.Entities.Wait.Close();
        }

        Dictionary<int, String> dicCateFilter = new Dictionary<int, string>();
        int i = 0;
        private string GetFilterCategory(int categoryID)
        {
            if (dicCateFilter.ContainsKey(categoryID))
            {
                return dicCateFilter[categoryID];
            }
            else
            {
                //codeContains = String.Format(@"""c{0}""", objCat.ID.ToString("D3"));
                String r = string.Empty;
                if (categoryID<10)
                {
                    r = "0"+categoryID.ToString();
                }
                else
                    r = categoryID.ToString();
                DBPhanSP.ListClassificationDataTable dt = new DBPhanSP.ListClassificationDataTable();
                QT.Users.DBPhanSPTableAdapters.ListClassificationTableAdapter adt = new QT.Users.DBPhanSPTableAdapters.ListClassificationTableAdapter();
                adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                adt.FillBy_SelectOne(dt, categoryID);
                if (dt.Rows.Count > 0 && i<3)
                {
                    int idParent = QT.Entities.Common.Obj2Int(dt.Rows[0]["ParentID"]);
                    if (idParent != 0)
                        r = GetFilterCategory(idParent) + "/" + r;
                }
                dt.Dispose();
                adt.Dispose();
                dicCateFilter[categoryID] = r;
                return r;
            }

        }
        #region Event OpenFileButton
        private void OpenFileButtonProduct_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextEditProduct.Text = openFileDialog1.FileName;
                pictureBoxProduct.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void OpenFileButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextEdit1.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void OpenFileButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextEdit2.Text = openFileDialog1.FileName;
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void OpenFileButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextEdit3.Text = openFileDialog1.FileName;
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void OpenFileButton4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextEdit4.Text = openFileDialog1.FileName;
                pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void OpenFileButton5_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextEdit5.Text = openFileDialog1.FileName;
                pictureBox5.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        #endregion

    }
}
