using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.Maps
{
    public partial class frmClassificationToTree : QT.Entities.frmBase
    {
        public frmClassificationToTree()
        {
            InitializeComponent();
        }

        private void ctrTreeCompany1_CreateNode(List<String> s, EventArgs e)
        {
            this.ctrTree1.SetParentNode();
            foreach (var item in s)
            {
                this.ctrTree1.AddChild(item);
            }
        }

        private void ctrTreeCompany1_IDCateChange(long IDcat)
        {
            if (this.xtraTabControl1.TabIndex == 1)
            {
                this.ctrProductInCategory1.IDClassification = IDcat;
                               
                //this.ctrProductInCategory1.LoadData();
            }
        }

        private void frmClassificationToTree_Load(object sender, EventArgs e)
        {
            this.ctrTree1.InitData();
        }

        private void ctrTreeCompany1_LevelMapChange(int level)
        {
            if (this.xtraTabControl1.TabIndex == 1)
            {
                this.ctrProductInCategory1.LevelMap = level;
            }
        }
        public override bool Save()
        {
            this.ctrTree1.Save();
            return true;
        }
       
    }
}