using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using QT.Entities;

namespace UpdateContentFTProduct
{
    public partial class frmUpdateContentFTProduct : Form
    {
        string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
        public frmUpdateContentFTProduct()
        {
            InitializeComponent();
        }

        private void frmUpdateContentFTProduct_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Connection.ConnectionString = connectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = connectionString;
        }
        
        private void UpdateContentFTButton_Click(object sender, EventArgs e)
        {
            Wait.Show("Start!");
            //ListIDSearch(Anh Trung) = KeySearch(Hải) 
            #region Cập nhật lại ListIDSearch(KeySearch) trong ListClassification
            listClassificationTableAdapter.Fill(dB.ListClassification);
            int count = dB.ListClassification.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                Wait.Show(string.Format("{0}/{1}", i+1, count));
                try
                {
                    int idcat = int.Parse(dB.ListClassification.Rows[i]["ID"].ToString());
                    string key = GetFilterCategory(idcat);
                    listClassificationTableAdapter.UpdateSearch(key, idcat);
                }
                catch (Exception ex)
                {
                    
                }
            }
            #endregion
            #region Update lại ContentFT của toàn bộ sản phẩm gốc
            try
            {
                this.productTableAdapter.UpdateContentFT();
            }
            catch (Exception ex)
            {
                
            }
            #endregion
            Wait.Close();
            Application.Exit();
        }

        Dictionary<int, String> dicCateFilter = new Dictionary<int, string>();
        private string GetFilterCategory(int categoryID)
        {
            if (dicCateFilter.ContainsKey(categoryID))
            {
                return dicCateFilter[categoryID];
            }
            else
            {
                String r = String.Format("c{0}_ ", categoryID.ToString("D3"));
                DB.ListClassificationDataTable dt = new DB.ListClassificationDataTable();
                DBTableAdapters.ListClassificationTableAdapter adt = new DBTableAdapters.ListClassificationTableAdapter();
                adt.Connection.ConnectionString = connectionString;
                adt.FillBy_ID(dt, categoryID);
                if (dt.Rows.Count > 0)
                {
                    int idParent = int.Parse(dt.Rows[0]["ParentID"].ToString());
                    if (idParent != 0)
                        r += " " + GetFilterCategory(idParent);
                }
                dt.Dispose();
                adt.Dispose();
                dicCateFilter[categoryID] = r;
                return r;
            }
        }
    }
}
