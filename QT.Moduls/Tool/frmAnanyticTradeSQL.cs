using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.Tool
{
    public partial class frmAnanyticTradeSQL : QT.Entities.frmBase
    {
        public frmAnanyticTradeSQL()
        {
            InitializeComponent();
        }

        private void frmAnanyticTradeSQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTool3.TempTrade' table. You can move, or remove it, as needed.
            this.tempTradeTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.tempTradeTableAdapter.Fill(this.dBTool3.TempTrade);

        }
    }
}
