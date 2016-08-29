using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QT.Entities;

namespace QT.Moduls.ProductID
{
    public partial class frmChuanHoaThongSoKyThuat : QT.Entities.frmBase
    {
        public frmChuanHoaThongSoKyThuat()
        {
            InitializeComponent();
        }

        private DBPropertiesTableAdapters.Product_PropertiesTableAdapter adt = new DBPropertiesTableAdapters.Product_PropertiesTableAdapter();
        private void frmChuanHoaThongSoKyThuat_Load(object sender, EventArgs e)
        {
            this.adt.Connection.ConnectionString = Server.ConnectionString;
            this.viewListValueOfCatFTTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.listClassificationTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            this.listClassificationTableAdapter.Fill(this.dBProperties.ListClassification);
            this.propertiesViewTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesViewTypeTableAdapter.Fill(this.dBProperties.PropertiesViewType);
            this.propertiesConfig_PropertiesTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesConfigTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesGroupTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesConfigTableAdapter.Fill(this.dBProperties.PropertiesConfig);
            this.propertiesGroupTableAdapter.FillBy_GroupLapMoi(this.dBProperties.PropertiesGroup);
            
        }

        private void iDPropertiesConfigTextBox_TextChanged(object sender, EventArgs e)
        {
            this.propertiesConfig_PropertiesTableAdapter.FillBy_IDPropertiesConfig(this.dBProperties.PropertiesConfig_Properties, Common.Obj2Int(this.iDPropertiesConfigTextBox.Text));
            this.gridViewListconfigProperties.ExpandAllGroups();
        }

        private void btLoadValue_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        public override bool RefreshData()
        {
            string cat = "%c" + QT.Entities.Common.Obj2Int(this.iDCatTextBox.Text).ToString("000") + "%";
            this.viewListValueOfCatFTTableAdapter.Fill(dBProperties.ViewListValueOfCatFT, cat, Common.Obj2Int(iDPropertiesTextBox.Text));
            return true;
        }
        private void btGetValue_Click(object sender, EventArgs e)
        {
            this.txtValueCurrent.Text = this.propertiesValueIDTextBox.Text;
            this.gridControl1.Focus();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            string txt1 = "Chuyển IDValue: "+this.propertiesValueIDTextBox.Text+" thành ID: "+this.txtValueCurrent.Text;
            if (MessageBox.Show(this, txt1, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                adt.UpdateQuery_NhapValueGiongNhau(Common.Obj2Int(this.txtValueCurrent.Text), Common.Obj2Int(iDPropertiesTextBox.Text), Common.Obj2Int(propertiesValueIDTextBox.Text));
                RefreshData();
            }
        }

        private void btChonCheck_Click(object sender, EventArgs e)
        {
            this.viewListValueOfCatFTBindingSource.EndEdit();
            string txt1 = "Chuyển toàn bộ id đã chọn thành id: "+this.txtValueCurrent.Text;
            if (MessageBox.Show(this, txt1, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                for (int i = 0; i < dBProperties.ViewListValueOfCatFT.Rows.Count; i++)
                {
                    bool check = false;
                    check = Common.Obj2Bool(dBProperties.ViewListValueOfCatFT.Rows[i]["Check"].ToString());
                    if (check)
                    {
                        int PropertiesID = Common.Obj2Int(dBProperties.ViewListValueOfCatFT.Rows[i]["PropertiesID"].ToString());
                        int PropertiesValueID = Common.Obj2Int(dBProperties.ViewListValueOfCatFT.Rows[i]["PropertiesValueID"].ToString());
                        Wait.Show("Đang chuyển ID: " + PropertiesValueID.ToString());
                        adt.UpdateQuery_NhapValueGiongNhau(Common.Obj2Int(this.txtValueCurrent.Text), PropertiesID, PropertiesValueID);
                    }
                }
            }
            Wait.Close();
            RefreshData();
        }
    }
}
