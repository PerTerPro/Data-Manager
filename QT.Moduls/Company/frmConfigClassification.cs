using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Company
{
    public partial class frmConfigClassification : QT.Entities.frmBase
    {
        public frmConfigClassification()
        {
            InitializeComponent();
        }

        private void frmConfigClassification_Load(object sender, EventArgs e)
        {
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.listClassificationTableAdapter.Fill(this.dBCom.ListClassification);
            this.companyTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.classificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }

        private void simpleButtonCheckCompany_Click(object sender, EventArgs e)
        {
            string domain = "%" + textEditDomain.Text + "%";
            try
            {
                companyTableAdapter.FillBy_Domain(dBCom.Company, domain);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Save();
        }
        public override bool Save()
        {
            this.classificationBindingSource.EndEdit();
            try
            {
                this.classificationTableAdapter.Update(dBCom.Classification);
                this.dBCom.Classification.AcceptChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
                return false;
            }
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                long idcompany = QT.Entities.Common.Obj2Int64(iDTextEdit.Text);
                this.classificationTableAdapter.FillBy_CompanyID(dBCom.Classification, idcompany);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }

        private void textEditDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButtonCheckCompany_Click(null, null);
            }
        }
    }
}
