using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Websosanh.NotificationSystem.Manager
{
    public partial class Form1 : Form
    {

        SqlDb sqlDb = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = "server=192.168.100.178; database=Notification; UID=sa; PWD=123456a@;";
            sqlDb = new SqlDb(connection);

            ReloadData();
        }

        private void ReloadData()
        {
            this.gridControl1.DataSource = sqlDb.GetTblData("select * from Channel");
            this.gridControl2.DataSource = sqlDb.GetTblData("select * from Client");
        }
    }
}
