using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.NewsRelation
{
    public partial class frmThreadViewType : QT.Entities.frmBase
    {
        public frmThreadViewType()
        {
            InitializeComponent();
        }

        private void frmViewType_Load(object sender, EventArgs e)
        {
            this.categoryTableAdapter.Fill(this.dB.Category);
            //this.threatTableAdapter.Fill(this.dB.Threat);
            this.threatViewTypeTableAdapter.Fill(this.dB.ThreatViewType);

        }

        private void cboViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            id = QT.Entities.Common.Obj2Int(cboViewType.SelectedValue.ToString());
            this.threatViewTableAdapter.FillBy_ViewType(this.dB.ThreatView, id);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.iDThreatViewTypeTextBox.Text = this.iDThreadSourceTextBox.Text;
            this.sTTViewTypeTextBox.Text = "100";
            int id = 0;
            id = QT.Entities.Common.Obj2Int(cboViewType.SelectedValue.ToString());
            this.viewTypeTextBox.Text = id.ToString();
            this.titleTextBox.Text = this.titleThreadSourceTextBox.Text;
            this.threatViewBindingSource.EndEdit();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            this.threatViewBindingSource.AddNew();
            this.iDThreatViewTypeTextBox.Text = this.iDThreadSourceTextBox.Text;
            this.sTTViewTypeTextBox.Text = "100";
            int id = 0;
            id = QT.Entities.Common.Obj2Int(cboViewType.SelectedValue.ToString());
            this.viewTypeTextBox.Text = id.ToString();
            this.titleTextBox.Text = this.titleThreadSourceTextBox.Text;
            this.threatViewBindingSource.EndEdit();
        }

        private void btUpdateThreadView_Click(object sender, EventArgs e)
        {
            this.threatViewBindingSource.EndEdit();
            this.threatViewTableAdapter.Update(dB.ThreatView);
        }
    }
}
