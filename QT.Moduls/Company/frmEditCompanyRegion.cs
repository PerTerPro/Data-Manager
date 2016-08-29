using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Websosanh.Core.Common.BAL;
using Websosanh.Core.Common.BO;
using Region = System.Drawing.Region;

namespace QT.Moduls.Company
{
    public partial class FrmEditCompanyRegion : QT.Entities.frmBase
    {
        private Tree<int, Websosanh.Core.Common.BO.Region> regionTree;
        private bool isEditting = false;
        private bool isLoadingData = false;
        private DBCom.CompanyAddressDataTable companyAddressDataTable;
        private string connectionStringCompanyAddress;
        public FrmEditCompanyRegion()
        {
            InitializeComponent();
            connectionStringCompanyAddress = Entities.Server.ConnectionString;
            if (string.IsNullOrEmpty(connectionStringCompanyAddress))
                connectionStringCompanyAddress =
                    ConfigurationManager.ConnectionStrings["UpdateSolrTools.Properties.Settings.QTConnectionString"].ToString();
            companyAddressTableAdapter.Connection = new SqlConnection(connectionStringCompanyAddress);
            companyAddressTableAdapter.Connection.Open();
            regionTree = RegionBAL.GetRegionTree(connectionStringCompanyAddress);
            var provinNodes = regionTree.GetAllNodeInLevel(1);
            foreach (var provinNode in provinNodes)
            {
                comboBoxProvin.Items.Add(new ComboboxItem()
                {
                    ID = provinNode.ID,
                    Value = provinNode.Value.Name
                });
            }

            RefreshData();
        }

        private void RefreshData()
        {
            isLoadingData = true;
            companyAddressTableAdapter.FillNullRegionRows(dBCom.CompanyAddress);
            dataGridViewCompanyAddress.DataSource = companyAddressBindingSource;
            isLoadingData = false;
        }

        private void dataGridViewCompanyAddress_SelectionChanged(object sender, EventArgs e)
        {
            if(isLoadingData)
                return;
            isEditting = false;
            if(dataGridViewCompanyAddress.CurrentRow == null)
                return;
            comboBoxProvin.Focus();
            if (dataGridViewCompanyAddress.CurrentRow.Cells["regionIDDataGridViewTextBoxColumn"].Value != DBNull.Value)
            {
                var currentDistrictID = (int)dataGridViewCompanyAddress.CurrentRow.Cells["regionIDDataGridViewTextBoxColumn"].Value;
                var currentDistrict = regionTree.GetNode(currentDistrictID).Value;
                var currentProvin = regionTree.GetParentNode(currentDistrictID).Value;
                
                comboBoxProvin.SelectedIndex = comboBoxProvin.Items.IndexOf(new ComboboxItem() {ID = currentProvin.ID, Value = currentProvin.Name});
                comboBoxProvin.Text = currentProvin.Name;
                UpdateComboBoxDistrictItems(currentProvin.ID);
                comboBoxDistrict.SelectedItem = comboBoxDistrict.Items.IndexOf(
                    new ComboboxItem() { ID = currentDistrict.ID, Value = currentDistrict.Name });
                comboBoxDistrict.Text = currentDistrict.Name;
            }
            else
            {
                comboBoxDistrict.Items.Clear();
                comboBoxDistrict.Text = "";
            }
            isEditting = true;
        }

        class ComboboxItem
        {
            public int ID;
            public string Value;

            public override string ToString()
            {
                return Value;
            }
        }

        private void UpdateComboBoxDistrictItems(int currentProvinID)
        {
            comboBoxDistrict.Items.Clear();
            var currentProvinDistricts = regionTree.GetNode(currentProvinID).ChildNodes.Select(x => x.Value);
            comboBoxDistrict.Items.Clear();
            foreach (var currentProvinDistrict in currentProvinDistricts)
            {
                comboBoxDistrict.Items.Add(new ComboboxItem()
                {
                    ID = currentProvinDistrict.ID,
                    Value = currentProvinDistrict.Name
                });
            }
        }

        private void comboBoxProvin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isEditting || comboBoxProvin.SelectedIndex < 0)
                return;
            var currentProvinId = ((ComboboxItem)comboBoxProvin.SelectedItem).ID;
            var currentProvin = regionTree.GetNode(currentProvinId).Value;
            var currentSourceRow = (DataRowView)companyAddressBindingSource.Current;
            currentSourceRow["ThanhPho"] = currentProvin.Name;
            //companyAddressBindingSource.EndEdit();
            //Update comboboxDistrict Items
            isEditting = false;
            UpdateComboBoxDistrictItems(currentProvin.ID);
            isEditting = true;
        }

        private void comboBoxDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isEditting || comboBoxDistrict.SelectedIndex < 0)
                return;
            var currentDistrictID = ((ComboboxItem)comboBoxDistrict.SelectedItem).ID;
            var currentDistrict = regionTree.GetNode(currentDistrictID).Value;
            var currentSourceRow = (DataRowView)companyAddressBindingSource.Current;
            currentSourceRow["QuanHuyen"] = currentDistrict.Name;
            currentSourceRow["RegionID"] = currentDistrict.ID;
            companyAddressBindingSource.EndEdit();
            dataGridViewCompanyAddress.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
            //dataGridViewCompanyAddress.Update();
        }

        private void buttonUpdateAll_Click(object sender, EventArgs e)
        {
            foreach (var row in dBCom.CompanyAddress)
            {
                if(!row.IsRegionIDNull())
                companyAddressTableAdapter.UpdateRegion(row.QuanHuyen, row.ThanhPho, row.RegionID, row.ID);
            }
            RefreshData();
        }

    }
}
