using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Financial.Backend
{
    public partial class FrmPropertyValue : Form
    {
        public FrmPropertyValue()
        {
            InitializeComponent();
        }

        private void propertyValueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
this.Validate();
            this.propertyValueBindingSource.EndEdit();
            this.propertyValueTableAdapter.Update(this.dBFinancial.PropertyValue);

                MessageBox.Show(@"Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

        }

        private void FrmPropertyValue_Load(object sender, EventArgs e)
        {
            this.propertyValueTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.propertyValueTableAdapter.Fill(this.dBFinancial.PropertyValue);
        }

        private void valueTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(valueTextEdit.Text))
            {
                idTextEdit.Text = WssCommon.GetIdFromText(valueTextEdit.Text).ToString();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName != "Value") return;
            string cellValue = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["Value"]).ToString();
            if (!string.IsNullOrEmpty(cellValue))
            {
                var id = WssCommon.GetIdFromText(cellValue).ToString();
                gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["Id"], id);
            }
            
        }
    }
}
