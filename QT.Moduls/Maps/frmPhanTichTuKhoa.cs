using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GABIZ.Base;
using System.Threading;
using DevExpress.XtraTreeList.Nodes;
using QT.Entities;

namespace QT.Moduls.Maps
{
    public partial class frmPhanTichTuKhoa : QT.Entities.frmBase
    {
        private Thread processThread;
        private List<int> listKewordCrc;
        private List<int> listKewordCrcTemp;
        private String _connection = "";
        bool isBusy = false;
        bool finish = true;
        public frmPhanTichTuKhoa()
        {
            InitializeComponent();
        }

        //private void LoadData()
        //{
        //    if (finish)
        //    {
        //        processThread = new Thread(new ThreadStart(doprocess));
        //        processThread.Start();
        //    }
        //}
        //void doprocess()
        //{
        //    finish = false;
        //    this.Invoke((MethodInvoker)delegate
        //    {
        //        lamess.Text = "Đang tải dữ liệu...";
        //    });
        //    this.Invoke((MethodInvoker)delegate
        //    {
        //        lamess.Text = "finish";
        //    });
        //    finish = true;
        //    if (processThread != null)
        //    {
        //        if (processThread.IsAlive)
        //        {
        //            processThread.Abort();
        //            processThread.Join();
        //            processThread = null;
        //        }
        //    }
        //}
        private void frmPhanTichTuKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kW.KeywordsTemp' table. You can move, or remove it, as needed.
            this.ctrSeoKeyword1.Init();
            this.ctrEditeKeyword1.Init();
        }

        private void btLoadData_Click(object sender, EventArgs e)
        {
            this.kW.WordExtrax.Rows.Clear();
            this.kW.WordExtraxTemp.Rows.Clear();
            this.kW.Keywords.Rows.Clear();
            this.kW.KeywordsTemp.Rows.Clear();
            this.keywordsTempTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.keywordsTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.productTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;


            listKewordCrc = new List<int>();
            lamess.Text = "Load keyword <0";
            this.keywordsTableAdapter.FillBy_KeyHashLess0(this.kW.Keywords);
            foreach (Data.KW.KeywordsRow dr in kW.Keywords)
            {
                listKewordCrc.Add(dr.KeyHash);
            }
            Application.DoEvents();
            lamess.Text = "Load keyword >0";
            this.keywordsTableAdapter.FillBy_KeyHashGread0(this.kW.Keywords);
            foreach (Data.KW.KeywordsRow dr in kW.Keywords)
            {
                listKewordCrc.Add(dr.KeyHash);
            }
            Application.DoEvents();

            listKewordCrcTemp = new List<int>();
            lamess.Text = "Load keyword Temp <0";
            this.keywordsTempTableAdapter.FillBy_KeyHashLess0(this.kW.KeywordsTemp);
            foreach (Data.KW.KeywordsTempRow dr in kW.KeywordsTemp)
            {
                listKewordCrcTemp.Add(dr.KeyHash);
            }
            Application.DoEvents();
            lamess.Text = "Load keyword Temp >0";
            this.keywordsTempTableAdapter.FillBy_KeyHashGrea0(this.kW.KeywordsTemp);
            foreach (Data.KW.KeywordsTempRow dr in kW.KeywordsTemp)
            {
                listKewordCrcTemp.Add(dr.KeyHash);
            }
            Application.DoEvents();

            lamess.Text = "Load Product Name >0";
            this.productTableAdapter.FillBy_CMS_GetFreeTextName_Page(kW.Product, Common.Obj2Int(txtPage.Text), Common.Obj2Int(txtSize.Text), txtSearch.Text.Trim());
            //this.productTableAdapter.FillBy_FreetextName(kW.Product, txtSearch.Text.Trim());
            // tải dữ liệu từ thuộc tính
            //Data.KW.ProductDataTable dt2 = new Data.KW.ProductDataTable();
           
            
            //Data.KW.ProductDataTable dt3 = new Data.KW.ProductDataTable();
            ////this.productTableAdapter.FillByLikeNamePropertyValue(dt2, "%" + txtSearch.Text.Trim() + "%");
            //this.productTableAdapter.FillBy_LogKeyword(dt3);
            ////kW.Product.Merge(dt2);
            //kW.Product.Merge(dt3);
           
          
        }

        int SoTuTach = 1;
        void doprocess()
        {
            finish = false;
            this.Invoke((MethodInvoker)delegate
            {
                lamess.Text = "Start process...";
            });

            Data.KW.WordExtraxDataTable dt = new Data.KW.WordExtraxDataTable();
            Data.KW.WordExtraxDataTable dttemp = new Data.KW.WordExtraxDataTable();
            Data.KW.ProductDataTable dtName = new Data.KW.ProductDataTable();
            this.Invoke((MethodInvoker)delegate
            {
                dtName.Merge(kW.Product);
            });

            if (chkNgram.Checked)
            {
                for (int i = 0; i < dtName.Count; i++)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        try
                        {
                            lamess.Text = String.Format("Process {0}/{1}...", i, dtName.Count);
                        }
                        catch (Exception ex)
                        {
                         
                        }
                    });
                    List<String> ls2 = new List<string>();
                    ls2 = NGramKeyword.DoDetect(dtName.Rows[i]["Name"].ToString());
                    foreach (string s in ls2)
                    {
                        int s_crc = Common.GetID_Keywords(s);
                        // check keyword in temp
                        int index1 = listKewordCrcTemp.BinarySearch(s_crc);
                        if (index1 < 0)
                        {
                            // từ khóa này không thuộc tập hợp từ linh tinh
                            // check keyword

                            int index = listKewordCrc.BinarySearch(s_crc);
                            if (index < 0)
                            {
                                listKewordCrc.Insert(~index, s_crc);
                                dt.Rows.Add(s, s_crc);
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < dtName.Count; i++)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lamess.Text = String.Format("Process {0}/{1}...", i, dtName.Count);
                    });
                    string[] lsk = dtName.Rows[i]["Name"].ToString().Trim().Replace("&bull;", " ").Split(' ');
                    int count = 1;
                    List<String> ls2 = new List<string>();
                    string s2 = "";
                    switch (SoTuTach)
                    {
                        case 1:
                            foreach (string s in lsk)
                            {
                                ls2.Add(s);
                            }
                            break;
                        case 2:
                            #region 2 keyword
                            foreach (string s in lsk)
                            {
                                if (count >= SoTuTach)
                                {
                                    s2 += s;
                                    ls2.Add(s2);
                                    s2 = "";
                                    count = 1;
                                    // tạm thời lấy 1 cặp đầu tiên
                                    break;
                                }
                                else
                                {
                                    s2 += s + " ";
                                    count++;
                                }
                            }
                            //if (lsk.Length > 2)
                            //{
                            //    int ii = 0;
                            //    foreach (string s in lsk)
                            //    {
                            //        if (ii > 1)
                            //        {
                            //            if (count >= SoTuTach)
                            //            {
                            //                s2 += s;
                            //                ls2.Add(s2);
                            //                s2 = "";
                            //                count = 0;
                            //            }
                            //            else
                            //            {
                            //                s2 += s + " ";
                            //                count++;
                            //            }
                            //        }
                            //        ii++;
                            //    }
                            //}
                            #endregion
                            break;
                        default:
                            #region  keyword
                            foreach (string s in lsk)
                            {
                                if (count >= SoTuTach)
                                {
                                    s2 += s;
                                    ls2.Add(s2);
                                    s2 = "";
                                    count = 1;
                                    // tạm thời lấy 1 cặp đầu tiên
                                    break;
                                }
                                else
                                {
                                    s2 += s + " ";
                                    count++;
                                }
                            }
                            #endregion
                            break;
                    }
                    foreach (string s in ls2)
                    {
                        int s_crc = Common.GetID_Keywords(s);
                        // check keyword in temp
                        int index1 = listKewordCrcTemp.BinarySearch(s_crc);
                        if (index1 < 0)
                        {
                            // từ khóa này không thuộc tập hợp từ linh tinh
                            // check keyword

                            int index = listKewordCrc.BinarySearch(s_crc);
                            if (index < 0)
                            {
                                listKewordCrc.Insert(~index, s_crc);
                                dt.Rows.Add(s, s_crc);
                            }
                        }
                    }
                }
            }
            
            dt.AcceptChanges();

            this.Invoke((MethodInvoker)delegate
            {
                this.kW.WordExtrax.Rows.Clear();
                this.kW.WordExtrax.Merge(dt);
                lamess.Text = "finish";
            });
            finish = true;
            if (processThread != null)
            {
                if (processThread.IsAlive)
                {
                    processThread.Abort();
                    processThread.Join();
                    processThread = null;
                }
            }
        }
        private void process()
        {
            if (finish)
            {
                processThread = new Thread(new ThreadStart(doprocess));
                processThread.Start();
            }
        }


        private void btProcess_Click(object sender, EventArgs e)
        {
            SoTuTach = Common.Obj2Int(txtSoTu.Text);
            process();
        }

        private void gridKe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.kW.WordExtraxTemp.Rows.Add(
               this.nameTextBox.Text.Trim(),
               this.cRCTextBox.Text.Trim());
            if (this.wordExtraxBindingSource.Count > 0)
            {
                this.wordExtraxBindingSource.RemoveCurrent();
            }
            this.wordExtraxBindingSource.EndEdit();
        }

        private void gridKeTemp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.kW.WordExtrax.Rows.Add(
              this.nameTextBox1.Text.Trim(),
              this.cRCTextBox1.Text.Trim());
            if (this.wordExtraxTempBindingSource.Count > 0)
            {
                this.wordExtraxTempBindingSource.RemoveCurrent();
            }
            this.wordExtraxTempBindingSource.EndEdit();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            foreach (Data.KW.WordExtraxRow dr in kW.WordExtrax)
            {
                try
                {
                    this.keywordsTableAdapter.Insert(dr.CRC, dr.Name, "", 0, 1, DateTime.Now, Common.GetID_Keywords(dr.Name), 0);
                }
                catch (Exception)
                {
                }
            }
            foreach (Data.KW.WordExtraxTempRow dr in kW.WordExtraxTemp)
            {
                try
                {
                    this.keywordsTempTableAdapter.Insert(dr.CRC, dr.Name, dr.CRC);
                }
                catch (Exception)
                {
                }
            }
        }

        private void btAuto_Click(object sender, EventArgs e)
        {
            this.wordExtraxBindingSource.MoveLast();
            this.kW.WordExtraxTemp.Rows.Clear();
            for (int i = kW.WordExtrax.Rows.Count - 1; i >= 0; i--)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lamess.Text = String.Format("Process {0}/{1}...", i, kW.WordExtrax.Rows.Count);
                });
                if (!QT.Entities.Common.ValidKeyword(this.nameTextBox.Text.Trim()))
                {
                    this.kW.WordExtraxTemp.Rows.Add(
                          this.nameTextBox.Text.Trim(),
                          this.cRCTextBox.Text.Trim());
                    if (this.wordExtraxBindingSource.Count > 0)
                    {
                        this.wordExtraxBindingSource.RemoveCurrent();
                    }
                }
                this.wordExtraxBindingSource.MovePrevious();

            }
            this.wordExtraxBindingSource.EndEdit();

        }

        private void btUpdateSoLanXuatHien_Click(object sender, EventArgs e)
        {
            Data.KW.KeywordsDataTable dt = new Data.KW.KeywordsDataTable();
            this.keywordsTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.keywordsTableAdapter.Fill(dt);
            DBTableAdapters.ProductTableAdapter adtp = new DBTableAdapters.ProductTableAdapter();
            adtp.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            int i = 0;
            foreach (Data.KW.KeywordsRow dr in dt)
            {
                i++;
                int a = 0;
                try
                {
                    String keyword = dr.KeyName.Trim().Replace(" ", "+");
                    a = (int)Convert.ToInt32(adtp.Product_SelectCountByFreetext_Name(keyword));
                }
                catch (Exception)
                { }
                this.keywordsTableAdapter.UpdateQuery_KeyFreq(a, DateTime.Now, dr.KeyHash);
                this.lamess.Text = String.Format("({0}/{1}) keyword:{2}={3}", i, dt.Rows.Count, dr.KeyName, a);
                Application.DoEvents();
            }
            this.lamess.Text = "Finish";
            dt.Clear();
            dt.Dispose();
        }

        private void btUpDateToDay_Click(object sender, EventArgs e)
        {
            Data.KW.KeywordsDataTable dt = new Data.KW.KeywordsDataTable();
            this.keywordsTableAdapter.FillBy_LessLastUpdate(dt, DateTime.Now.AddDays(-1));
            DBTableAdapters.ProductTableAdapter adtp = new DBTableAdapters.ProductTableAdapter();
            adtp.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            int i = 0;
            foreach (Data.KW.KeywordsRow dr in dt)
            {
                i++;
                int a = 0;
                try
                {
                    String keyword = dr.KeyName.Trim().Replace(" ", "+");
                    a = (int)Convert.ToInt32(adtp.Product_SelectCountByFreetext_Name(keyword));
                }
                catch (Exception)
                { }
                this.keywordsTableAdapter.UpdateQuery_KeyFreq(a, DateTime.Now, dr.KeyHash);
                this.lamess.Text = String.Format("({0}/{1}) keyword:{2}={3}", i, dt.Rows.Count, dr.KeyName, a);
                Application.DoEvents();
            }
            this.lamess.Text = "Finish";
            dt.Clear();
            dt.Dispose();
        }

        private void ctrEditeKeyword1_Load(object sender, EventArgs e)
        {

        }
    }
}
