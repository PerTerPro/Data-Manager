using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Financial.Brand
{
    public partial class FrmBrandManager : Form
    {
        public FrmBrandManager()
        {
            InitializeComponent();
        }

        private void brandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.brandBindingSource.EndEdit();
                this.brandTableAdapter.Update(this.dBFinancial.Brand);

                MessageBox.Show(@"Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmBrandManager_Load(object sender, EventArgs e)
        {
            this.brandTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.brandTableAdapter.Fill(this.dBFinancial.Brand);

        }
    }
}
