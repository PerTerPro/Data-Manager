using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.ProductID
{
    public partial class frmGhepChuyenMucVoiDinhNghia : QT.Entities.frmBase
    {
        public frmGhepChuyenMucVoiDinhNghia()
        {
            InitializeComponent();
        }

        private void frmGhepChuyenMucVoiDinhNghia_Load(object sender, EventArgs e)
        {
            this.propertiesConfigTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;

            RefreshData();
            

        }

        public override bool RefreshData()
        {
            this.propertiesConfigTableAdapter.Fill(this.dBProperties.PropertiesConfig);
            this.listClassificationTableAdapter.Fill(this.dBProperties.ListClassification);
            this.tlClassification.ExpandAll();
            expand = true;
            return true;
        }
        public override bool Save()
        {
            this.listClassificationBindingSource.EndEdit();
            this.listClassificationTableAdapter.Update(dBProperties.ListClassification);
            return true;
        }
        private bool expand = false;
        private void btExpan_Click(object sender, EventArgs e)
        {
            if (expand)
            {
                tlClassification.CollapseAll();
                expand = false;
            }
            else
            {
                this.tlClassification.ExpandAll();
                expand = true;
            }

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            Save();
        }

    }
}
