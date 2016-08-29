using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QT.Entities;
using QT.Moduls.Tool;
using QT.Moduls.Tool.DBToolTableAdapters;

namespace QT.Moduls.ProductID
{
    public partial class frmDinhNghiaThongSoKyThuat : QT.Entities.frmBase
    {
        public frmDinhNghiaThongSoKyThuat()
        {
            InitializeComponent();
        }

        private void frmDinhNghiaThongSoKyThuat_Load(object sender, EventArgs e)
        {
            this.propertiesViewTypeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesViewTypeTableAdapter.Fill(this.dBProperties.PropertiesViewType);
            this.propertiesConfig_PropertiesTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesConfigTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesGroupTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.propertiesConfigTableAdapter.Fill(this.dBProperties.PropertiesConfig);
            this.propertiesGroupTableAdapter.FillBy_GroupLapMoi(this.dBProperties.PropertiesGroup);

        }
        public override bool Save()
        {
            this.propertiesConfigBindingSource.EndEdit();
            this.propertiesConfigTableAdapter.Update(this.dBProperties.PropertiesConfig);
            return true;
        }
        private void propertiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void lookUpPropertiesGroup_EditValueChanged(object sender, EventArgs e)
        {
            int groupID=0;
            groupID = QT.Entities.Common.Obj2Int(this.lookUpPropertiesGroup.EditValue);
            this.propertiesTableAdapter.FillByGroup(this.dBProperties.Properties, groupID);
        }

        private void btChuyenToanBo_Click(object sender, EventArgs e)
        {
            this.propertiesBindingSource.MoveFirst();
            foreach(DBProperties.PropertiesRow dr in this.dBProperties.Properties)
            {
                int count = Common.Obj2Int(this.propertiesConfig_PropertiesTableAdapter.ScalarQueryCountCheck(Common.Obj2Int(this.iDPropertiesConfigTextBox.Text), dr.ID));
                if(count<=0){
                    int stt = 0;
                    try
                    {
                        stt = Common.Obj2Int(dr.STT);
                    }
                    catch (Exception)
                    {
                    }
                    this.propertiesConfig_PropertiesTableAdapter.Insert(Common.Obj2Int(this.iDPropertiesConfigTextBox.Text), dr.ID, stt, true, 1, 1, stt, stt, false);
                }
            }
            this.propertiesConfig_PropertiesTableAdapter.FillBy_IDPropertiesConfig(this.dBProperties.PropertiesConfig_Properties,Common.Obj2Int(this.iDPropertiesConfigTextBox.Text));
            this.gridViewListconfigProperties.ExpandAllGroups();
        }

        private void iDPropertiesConfigTextBox_TextChanged(object sender, EventArgs e)
        {
            this.propertiesConfig_PropertiesTableAdapter.FillBy_IDPropertiesConfig(this.dBProperties.PropertiesConfig_Properties, Common.Obj2Int(this.iDPropertiesConfigTextBox.Text));
            this.gridViewListconfigProperties.ExpandAllGroups();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            Wait.Show("Đang lưu dữ liệu");
            this.propertiesConfigPropertiesBindingSource.EndEdit();
            this.propertiesConfig_PropertiesTableAdapter.Update(this.dBProperties.PropertiesConfig_Properties);
            Wait.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void btXoaThuocTinhThua_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Ban co muon xoa toan bo thuoc tinh thua khong duoc map voi dinh nghia  khong?",
                    "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                int currentClassId = Int32.Parse(iDPropertiesConfigTextBox.Text);
                Task deletePropertiesTask = new Task(() => DoDeleteThuocTinhThua(currentClassId));
                deletePropertiesTask.Start();
            }
        }

        private void DoDeleteThuocTinhThua(int classId)
        {
            try
            {
                //Get all product ID;
                var productIdTable = new QT.Moduls.Tool.DBTool.ProductPerClassDataTable();
                Tool.DBToolTableAdapters.ProductPerClassTableAdapter adt = new ProductPerClassTableAdapter();
                adt.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
                adt.Fill_ProductPerClass(productIdTable, classId);

                var listPropertyId = new List<int>();
                for (int propertyIndex = 0;
                    propertyIndex < this.dBProperties.PropertiesConfig_Properties.Rows.Count;
                    propertyIndex++)
                {
                    listPropertyId.Add(
                        QT.Entities.Common.Obj2Int(
                            this.dBProperties.PropertiesConfig_Properties.Rows[propertyIndex]["IDProperties"]));
                }
                var connProductProperties = new SqlConnection(QT.Entities.Server.ConnectionString);
                connProductProperties.Open();
                var connString =
                       string.Format(
                           "DELETE FROM Product_Properties WHERE (ProductID = @ProductID) AND PropertiesID NOT IN ({0})",
                           string.Join(",", listPropertyId));
                int count = 0;
                for (int rowIndex = 0; rowIndex < productIdTable.Rows.Count; rowIndex ++)
                {
                    var productId = QT.Entities.Common.Obj2Int64(productIdTable.Rows[rowIndex]["ID"]);
                    var cmd = new SqlCommand(connString, connProductProperties);
                    cmd.Parameters.AddWithValue("ProductID", productId);
                    cmd.ExecuteNonQuery();
                    count++;

                }
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
