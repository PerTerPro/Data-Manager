using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.Maps
{
    public partial class frmChonChuyenMucGoc : Form
    {
        public frmChonChuyenMucGoc()
        {
            InitializeComponent();
        }

        private void frmChonChuyenMucGoc_Load(object sender, EventArgs e)
        {
            this.ctrTree1.InitData();
            this.ctrTree1.LoadData();
        }

        public int IDClassification = 0;
        public string NameClassification = "";
        public string ListIDSearch = "";
        private void btSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            IDClassification = ctrTree1.GetIDClassification();
            NameClassification = ctrTree1.GetNameClassification();
            ListIDSearch = ctrTree1.GetListIDSearch();
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
