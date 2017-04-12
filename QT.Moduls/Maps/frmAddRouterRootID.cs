using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.Maps
{
    public partial class frmAddRouterRootID : Form
    {
        private long _rootId;
        private long _oldMappingId;
        public frmAddRouterRootID(long rootId)
        {
            InitializeComponent();
            _rootId = rootId;
        }

        private void frmAddRouterRootID_Load(object sender, EventArgs e)
        {
            this.routerRootProductTableAdapter.Connection.ConnectionString = Server.ConnectionString;
            if (_rootId != 0)
            {
                this.routerRootProductTableAdapter.FillBy_RootID(this.dBPMan.RouterRootProduct, _rootId);
                if (dBPMan.RouterRootProduct.Rows.Count > 0)
                {
                    _oldMappingId = Common.Obj2Int64(dBPMan.RouterRootProduct.Rows[0]["MappingRootID"]);
                    if (_oldMappingId != 0)
                    {
                        btnEdit.Visible = true;
                        btnDelete.Visible = true;
                    }
                    else
                        btnAdd.Visible = true;
                }
                else { rootIDTextEdit.Text = _rootId.ToString(); btnAdd.Visible = true; }
                }
            else
                btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            long mappingId = Common.Obj2Int64(mappingRootIDTextEdit.Text);
            if (mappingId == 0)
            {
                MessageBox.Show("Nhập ID SP gốc cần map!");
            }
            else
            {
                try
                {
                    routerRootProductTableAdapter.Insert(_rootId, mappingId);
                    MessageBox.Show("Thiết lập mapping thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            long mappingId = Common.Obj2Int64(mappingRootIDTextEdit.Text);
            if (mappingId == 0)
            {
                MessageBox.Show("Nhập ID SP gốc cần map!");
            }
            else
            {
                try
                {
                    routerRootProductTableAdapter.UpdateMappingId(mappingId, _rootId, _oldMappingId);
                    MessageBox.Show("Sửa thiết lập mapping thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                routerRootProductTableAdapter.DeleteQuery(_rootId);
                MessageBox.Show("Xóa thiết lập mapping thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }

        }
    }
}
