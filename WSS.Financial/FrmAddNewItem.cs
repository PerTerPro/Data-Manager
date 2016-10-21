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
    public partial class FrmAddNewItem : Form
    {
        private int _categoryId;
        public FrmAddNewItem(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
        }

        private void FrmAddNewItem_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
