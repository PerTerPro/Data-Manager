using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Financial
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.categoryBindingSource.EndEdit();
                this.categoryTableAdapter.Update(this.dBFinancial.Category);
                MessageBox.Show(@"Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBFinancial.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            this.categoryTableAdapter.Fill(this.dBFinancial.Category);

        }
    }
}
