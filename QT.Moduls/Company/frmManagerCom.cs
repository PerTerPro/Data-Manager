using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;

namespace QT.Moduls.Company
{
    public partial class frmManagerCom : QT.Entities.frmBase
    {
        public frmManagerCom()
        {
            InitializeComponent();
        }
        private DBCom.CompanyViewDataTable dtView = new DBCom.CompanyViewDataTable();
        private Dictionary<long, string> listManDic = new Dictionary<long, string>();

        private void frmManagerCom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCom.ListComMan' table. You can move, or remove it, as needed.
            this.listComManTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.managerTypeRCompanyTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.companyViewTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.managerTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.companyOfTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            RefreshData();
            try
            {
                this.companyViewTableAdapter.FillBy_StatusAll(dtView, QT.Entities.Common.CompanyStatus.CONFIG);
            }
            catch (Exception)
            {
            }
        }

        private void iDManagerTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            int idtype = QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text.Trim());
            this.companyOfTypeTableAdapter.FillBy_IDType(dBCom.CompanyOfType, idtype);

        }

        public override bool Save()
        {
            try
            {
                this.managerTypeBindingSource.EndEdit();
                this.managerTypeTableAdapter.Update(this.dBCom.ManagerType);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public override bool RefreshData()
        {
            try
            {
                this.managerTypeTableAdapter.Fill(this.dBCom.ManagerType);
                NapDictionList();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void NapDictionList()
        {
            try
            {
                this.listComManTableAdapter.Fill(dBCom.ListComMan);
                listManDic = new Dictionary<long, string>();
                foreach (DBCom.ListComManRow dr in this.dBCom.ListComMan)
                {
                    if (listManDic.ContainsKey(dr.IDCompany))
                    {
                        listManDic[dr.IDCompany] += "-" + dr.Name;
                    }
                    else
                    {
                        listManDic.Add(dr.IDCompany, dr.Name);
                    }
                }
            }
            catch (Exception)
            {
            }
        }


        private void btFillter_Click(object sender, EventArgs e)
        {
            try
            {
                this.companyViewTableAdapter.FillBy_StatusAll(dtView, QT.Entities.Common.CompanyStatus.CONFIG);
            }
            catch (Exception)
            {
            }
            DBComTableAdapters.CompanyTableAdapter adtCompany = new DBComTableAdapters.CompanyTableAdapter();
            adtCompany.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            adtCompany.UpdateQuery_PageRankIsNull_0();
            adtCompany.UpdateQuery_TotalViewMonthIsNull_0();
            adtCompany.Connection.Close();
            adtCompany.Dispose();
            NapDictionList();
            DBCom.CompanyViewDataTable dtViewTemp = new DBCom.CompanyViewDataTable();

            dBCom.CompanyView.Rows.Clear();
            foreach (DBCom.CompanyViewRow dr in dtView)
            {
                bool valid = false;
                foreach (DBCom.CompanyOfTypeRow drOf in dBCom.CompanyOfType)
                {
                    if (dr.ID == drOf.ID)
                    {
                        valid = true;
                        break;
                    }
                }
                if (!valid)
                {
                    DBCom.CompanyViewRow drnew = this.dBCom.CompanyView.NewCompanyViewRow();
                    //drnew = dr;
                    drnew.ID = dr.ID;
                    drnew.Domain = dr.Domain;
                    drnew.TotalProduct = Common.Obj2Int(dr.TotalProduct);
                    drnew.TotalValid = Common.Obj2Int(dr.TotalValid);
                    drnew.TotalQueue = Common.Obj2Int(dr.TotalQueue);
                    drnew.TotalVisited = Common.Obj2Int(dr.TotalVisited);
                    drnew.PageRank = Common.Obj2Int(dr.PageRank);
                    drnew.TotalViewMonth = dr.TotalViewMonth;
                    if (listManDic.ContainsKey(dr.ID))
                    {
                        drnew.ManagerType = listManDic[dr.ID].ToString();
                    }
                    this.dBCom.CompanyView.Rows.Add(drnew);
                }
                dtViewTemp.AcceptChanges();
            }


        }

        private void btAddCom_Click(object sender, EventArgs e)
        {
            DBCom.CompanyOfTypeRow dr = this.dBCom.CompanyOfType.NewCompanyOfTypeRow();
            dr.ID = QT.Entities.Common.Obj2Int64(iDCompanyViewTextBox.Text);
            dr.Domain = domainCompanyViewTextBox.Text;
            dr.IDType = QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text);
            dr.PageRank = QT.Entities.Common.Obj2Int(pageRankTextBox.Text);
            dr.TotalProduct = QT.Entities.Common.Obj2Int(totalProductTextBox.Text);
            dr.TotalQueue = QT.Entities.Common.Obj2Int(totalQueueTextBox.Text);
            dr.TotalValid = QT.Entities.Common.Obj2Int(totalValidTextBox.Text);
            dr.TotalVisited = QT.Entities.Common.Obj2Int(totalVisitedTextBox.Text);

            this.dBCom.CompanyOfType.Rows.Add(dr);
            dBCom.CompanyOfType.AcceptChanges();
            this.companyViewBindingSource.RemoveCurrent();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                this.companyOfTypeBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
            }
        }

        private void btSaveTypeOf_Click(object sender, EventArgs e)
        {
            this.companyOfTypeBindingSource.EndEdit();
            int idtype = Entities.Common.Obj2Int(iDManagerTypeTextBox.Text);
            try
            {
                this.managerTypeRCompanyTableAdapter.DeleteQuery_IDType(idtype);
                foreach (DBCom.CompanyOfTypeRow dr in dBCom.CompanyOfType)
                {
                    long id =0;
                    try
                    {
                        id = QT.Entities.Common.Obj2Int64(dr.ID);
                        this.managerTypeRCompanyTableAdapter.DeleteQuery_IDCompany(id);
                        this.managerTypeRCompanyTableAdapter.Insert(idtype, id);
                    }
                    catch (Exception)
                    {
                    }
                    //
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi đang insert data, phải update lại");
            }
            
        }

        private void gridListCurrent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.companyOfTypeBindingSource.RemoveCurrent();
        }

        private void grvListAll_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DBCom.CompanyOfTypeRow dr = this.dBCom.CompanyOfType.NewCompanyOfTypeRow();
            dr.ID = QT.Entities.Common.Obj2Int64(iDCompanyViewTextBox.Text);
            dr.Domain = domainCompanyViewTextBox.Text;
            dr.IDType = QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text);
            dr.PageRank = QT.Entities.Common.Obj2Int(pageRankTextBox.Text);
            dr.TotalProduct = QT.Entities.Common.Obj2Int(totalProductTextBox.Text);
            dr.TotalQueue = QT.Entities.Common.Obj2Int(totalQueueTextBox.Text);
            dr.TotalValid = QT.Entities.Common.Obj2Int(totalValidTextBox.Text);
            dr.TotalVisited = QT.Entities.Common.Obj2Int(totalVisitedTextBox.Text);

            this.dBCom.CompanyOfType.Rows.Add(dr);
            dBCom.CompanyOfType.AcceptChanges();
            this.companyViewBindingSource.RemoveCurrent();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            this.managerTypeBindingSource.RemoveCurrent();
        }

        private void toolChuyenNhom_Click(object sender, EventArgs e)
        {
            frmChonNhomQuanLy frm = new frmChonNhomQuanLy();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // delete cong ty ở tất cả các nhóm
                // insert vào nhóm mới
                long idcom = Common.Obj2Int64(this.iDTextBox.Text);
                this.managerTypeRCompanyTableAdapter.DeleteQuery_IDCompany(idcom);
                this.managerTypeRCompanyTableAdapter.Insert(frm.IDManager, idcom);
                this.companyOfTypeBindingSource.RemoveCurrent();
            }
            frm.Dispose();
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            long idcom = Common.Obj2Int64(this.iDTextBox.Text);
            this.ctrLogMananger1.loadCompany(idcom);
        }

        private void toolXoaKhoiNhom_Click(object sender, EventArgs e)
        {

        }

        private void btChamCongDuyet_Click(object sender, EventArgs e)
        {
            this.companyOfTypeBindingSource.MoveFirst();
            QT.Users.ChamCongUser obj = new Users.ChamCongUser();
            int idUser = obj.GetIDUserByIDManagerType(QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text));
            if (idUser == 0)
            {
                QT.Users.frmListUserOfTypeManager frm = new Users.frmListUserOfTypeManager(QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    idUser = frm.IDUser;
                }
                else
                {
                    idUser = 1; // admin
                }
                frm.Dispose();
            }
            for (int i = 0; i < companyOfTypeBindingSource.Count; i++)
            {
                long idcom = Common.Obj2Int64(this.iDTextBox.Text);
                
                obj.InsertCongViec(idUser,
                    Common.JobType.Job_DuyetWeb,
                    String.Format("Duyệt {0} valid {1}/{2}", domainTextBox.Text, Common.Obj2Int(this.totalValidOfTypeTextBox.Text), Common.Obj2Int(this.totalProductOfTypeTextBox.Text)),
                    DateTime.Now,
                    1,
                    idcom);
                companyOfTypeBindingSource.MoveNext();
            }

        }

        private void btChamCongErr_Click(object sender, EventArgs e)
        {
            this.companyOfTypeBindingSource.MoveFirst();
            QT.Users.ChamCongUser obj = new Users.ChamCongUser();
            int idUser = obj.GetIDUserByIDManagerType(QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text));
            if (idUser == 0)
            {
                QT.Users.frmListUserOfTypeManager frm = new Users.frmListUserOfTypeManager(QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    idUser = frm.IDUser;
                }
                else
                {
                    idUser = 1; // admin
                }
                frm.Dispose();
            }
            for (int i = 0; i < companyOfTypeBindingSource.Count; i++)
            {
                long idcom = Common.Obj2Int64(this.iDTextBox.Text);

                obj.InsertCongViec(idUser,
                    Common.JobType.Job_ConfigWebErr,
                    String.Format("Config Err {0} valid {1}/{2} err:{3}", 
                                domainTextBox.Text, 
                                Common.Obj2Int(this.totalValidOfTypeTextBox.Text), 
                                Common.Obj2Int(this.totalProductOfTypeTextBox.Text),
                                this.ctrLogMananger1.GetErrCurrent()),
                    DateTime.Now,
                    1,
                    idcom);
                companyOfTypeBindingSource.MoveNext();
            }
        }

        private void btChamCongOK_Click(object sender, EventArgs e)
        {
            this.companyOfTypeBindingSource.MoveFirst();
            QT.Users.ChamCongUser obj = new Users.ChamCongUser();
            int idUser = obj.GetIDUserByIDManagerType(QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text));
            if (idUser == 0)
            {
                QT.Users.frmListUserOfTypeManager frm = new Users.frmListUserOfTypeManager(QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    idUser = frm.IDUser;
                }
                else
                {
                    idUser = 1; // admin
                }
                frm.Dispose();
            }
            for (int i = 0; i < companyOfTypeBindingSource.Count; i++)
            {
                long idcom = Common.Obj2Int64(this.iDTextBox.Text);

                obj.InsertCongViec(idUser,
                    Common.JobType.Job_ConfigWebOK,
                    String.Format("Config OK {0} valid {1}/{2}", domainTextBox.Text, Common.Obj2Int(this.totalValidOfTypeTextBox.Text), Common.Obj2Int(this.totalProductOfTypeTextBox.Text)),
                    DateTime.Now,
                    1,
                    idcom);
                companyOfTypeBindingSource.MoveNext();
            }
        }

        private void btChamCongDayWeb_Click(object sender, EventArgs e)
        {
            this.companyOfTypeBindingSource.MoveFirst();
            QT.Users.ChamCongUser obj = new Users.ChamCongUser();
            int idUser = obj.GetIDUserByIDManagerType(QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text));
            if (idUser == 0)
            {
                QT.Users.frmListUserOfTypeManager frm = new Users.frmListUserOfTypeManager(QT.Entities.Common.Obj2Int(iDManagerTypeTextBox.Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    idUser = frm.IDUser;
                }
                else
                {
                    idUser = 1; // admin
                }
                frm.Dispose();
            }
            for (int i = 0; i < companyOfTypeBindingSource.Count; i++)
            {
                long idcom = Common.Obj2Int64(this.iDTextBox.Text);

                obj.InsertCongViec(idUser,
                    Common.JobType.Job_DayWeb,
                    String.Format("Đẩy web {0} valid {1}/{2}", domainTextBox.Text, Common.Obj2Int(this.totalValidOfTypeTextBox.Text), Common.Obj2Int(this.totalProductOfTypeTextBox.Text)),
                    DateTime.Now,
                    1,
                    idcom);
                companyOfTypeBindingSource.MoveNext();
            }
        }

        private void btDeleteQueue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All data visited link can be delete?", "Messenger", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Crawler.DBQueueTableAdapters.VisitedLinksTableAdapter adt = new Crawler.DBQueueTableAdapters.VisitedLinksTableAdapter();
                    adt.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
                    Crawler.DBQueueTableAdapters.QueueLinksTableAdapter adtq = new Crawler.DBQueueTableAdapters.QueueLinksTableAdapter();
                    adtq.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
                    this.companyOfTypeBindingSource.MoveFirst();
                    for (int i = 0; i < companyOfTypeBindingSource.Count; i++)
                    {
                        long idcom = Common.Obj2Int64(this.iDTextBox.Text);
                        adt.DeleteQuery_ByCompany(idcom);
                        adtq.DeleteQuery_ALL_ByCompany(idcom);
                        txtResult.Text = string.Format("Clear {0}/{1}", i, companyOfTypeBindingSource.Count);
                        Application.DoEvents();
                        companyOfTypeBindingSource.MoveNext();
                    }
                    adt.Dispose();
                    adtq.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "xlsx";
            this.saveFileDialog1.FileName = "listwebsite.xls";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.gridView2.ExportToExcelOld(saveFileDialog1.FileName);
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip2.Show(this.gridControl1, new Point(e.X, e.Y));
            }
        }

        private void waitFindNewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductAdapter sqlDb = new ProductAdapter(new SqlDb(QT.Entities.Server.ConnectionString));
            var row = this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as DataRowView;
            sqlDb.UpdateToWaitFindNew(Convert.ToInt64(row["ID"]));
            MessageBox.Show("OK");
        }

    }
}
