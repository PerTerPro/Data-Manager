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
    public partial class frmChonRegion : Form
    {
        public frmChonRegion()
        {
            InitializeComponent();
        }
        private Tree<int, Websosanh.Core.Common.BO.Region> regionTree;

        private void frmChonRegion_Load(object sender, EventArgs e)
        {
            connectionStringCompanyAddress = Entities.Server.ConnectionString;
            //if (string.IsNullOrEmpty(connectionStringCompanyAddress))
            //    connectionStringCompanyAddress =
            //        ConfigurationManager.ConnectionStrings["UpdateSolrTools.Properties.Settings.QTConnectionString"].ToString();
            companyAddressTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;// = new SqlConnection(connectionStringCompanyAddress);
            //companyAddressTableAdapter.Connection.Open();
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
        }



        private bool isEditting = false;
        private bool isLoadingData = false;
        private DBCom.CompanyAddressDataTable companyAddressDataTable;
        private string connectionStringCompanyAddress;




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
            comboBoxDistrict.Text = "";
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


        private void comboBoxDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isEditting || comboBoxDistrict.SelectedIndex < 0)
                return;
            var currentDistrictID = ((ComboboxItem)comboBoxDistrict.SelectedItem).ID;
            var currentDistrict = regionTree.GetNode(currentDistrictID).Value;
            //var currentSourceRow = (DataRowView)companyAddressBindingSource.Current;
            NameQuanHuyen = currentDistrict.Name;
            IDRegion = currentDistrict.ID;
            //dataGridViewCompanyAddress.Update();
        }

        private void comboBoxProvin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var currentProvinId = ((ComboboxItem)comboBoxProvin.SelectedItem).ID;
            var currentProvin = regionTree.GetNode(currentProvinId).Value;
            //var currentSourceRow = (DataRowView)companyAddressBindingSource.Current;
            NameThanhPho = currentProvin.Name;
            //companyAddressBindingSource.EndEdit();
            //Update comboboxDistrict Items
            isEditting = false;
            UpdateComboBoxDistrictItems(currentProvin.ID);
            isEditting = true;
        }






        public string NameQuanHuyen { get; set; }
        public string NameThanhPho { get; set; }
        public int IDRegion { get; set; }

        private void btChon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
