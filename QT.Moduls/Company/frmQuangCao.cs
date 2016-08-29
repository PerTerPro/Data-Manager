using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using QT.Entities;

namespace QT.Moduls.Company
{
    public partial class frmQuangCao : QT.Entities.frmBase
    {
        long _companyID = 0;
        public override bool Save()
        {
            try
            {
                this.productQuangCaoBindingSource.EndEdit();
                this.productQuangCaoTableAdapter.Update(this.dBCom.ProductQuangCao);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
        public override bool RefreshData()
        {
            this.productQuangCaoTableAdapter.FillBy_CompanyValidAdd(dBCom.ProductQuangCao, _companyID, true);
            return true;    
        }
      
        public frmQuangCao(long CompanyID)
        {
            InitializeComponent();
            _companyID = CompanyID;
            this.Text = "loadQuangCao-" + _companyID.ToString();
            this.productQuangCaoTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }

        private void frmQuangCao_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public frmQuangCao()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            this.productQuangCaoTableAdapter.FillBy_CompanyValid(dBCom.ProductQuangCao, _companyID);
        }

        private void btLoadQuangCao_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (this.productQuangCaoBindingSource.Count > 0)
            {
                this.productQuangCaoBindingSource.MoveFirst();
                for (int i = 0; i < this.productQuangCaoBindingSource.Count; i++)
                {
                    this.addPositionTextBox.Text = "0";
                    this.productQuangCaoBindingSource.MoveNext();
                }
            }
        }

        private void btUpdateView_Click(object sender, EventArgs e)
        {
            QT.Moduls.Maps.DBPManTableAdapters.Product_LogsTableAdapter adtLog = new QT.Moduls.Maps.DBPManTableAdapters.Product_LogsTableAdapter();
            adtLog.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            int i = 0;
            foreach (DBCom.ProductQuangCaoRow dr in this.dBCom.ProductQuangCao)
            {
                try
                {
                    int viewCount = 0;
                    try
                    {
                        viewCount = Common.Obj2Int(adtLog.ScalarQuery_SumCountByProductID_FromDate(dr.ID, DateTime.Now.AddDays(-30)));
                    }
                    catch (Exception)
                    {
                    }
                    this.productQuangCaoTableAdapter.UpdateQuery_ViewCount(viewCount, dr.ID);
                    i++;
                    this.lamss.Text = string.Format("{0}/{1}-{2}", i, dBCom.ProductQuangCao.Rows.Count, viewCount);
                    Application.DoEvents();
                }
                catch (Exception)
                {
                }
                
            }
        }
    }
}
