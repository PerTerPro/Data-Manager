using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.Company
{
    public partial class ctrLogMananger : UserControl
    {
        public ctrLogMananger()
        {
            InitializeComponent();
            

        }
        public void loadCompany(long idCompany)
        {
            try
            {
                this.managerCompanyLogTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                this.managerCompanyLogTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                this.managerCompanyLogTypeTableAdapter.Fill(dBCom.ManagerCompanyLogType);
                this.managerCompanyLogTableAdapter.FillBy_IDCom(dBCom.ManagerCompanyLog, idCompany);
                this.dBCom.ManagerCompanyLog.IDCompanyColumn.DefaultValue = idCompany;
                this.dBCom.ManagerCompanyLog.DateAddColumn.DefaultValue = DateTime.Now;
                this.dBCom.ManagerCompanyLog.TypeColumn.DefaultValue = 1;
            }
            catch (Exception)
            {
            }
        }
        public void Save()
        {
            try
            {
                this.managerCompanyLogBindingSource.EndEdit();
                this.managerCompanyLogTableAdapter.Update(dBCom.ManagerCompanyLog);
            }
            catch (Exception)
            {
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public String GetErrCurrent()
        {
            string r = "";
            if (dBCom.ManagerCompanyLog.Rows.Count > 0)
            {
                r = dBCom.ManagerCompanyLog.Rows[0]["NoiDung"].ToString();
            }
            return r;
        }
        private void gridControl1_Leave(object sender, EventArgs e)
        {
            Save();
        }
    }
}
