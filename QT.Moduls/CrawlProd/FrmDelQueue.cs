using QT.Entities.Data;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlProd
{
    public partial class FrmDelQueue : Form
    {
        public FrmDelQueue()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Queue", typeof(string));
            var a = Regex.Matches(richTextBox1.Text, textBox1.Text);
            foreach(var item in a)
            {
                tbl.Rows.Add(item.ToString());
            }
            this.gridControl1.DataSource = tbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IConnection conection = RabbitMQCreator.CreateConnection();
                var model = conection.CreateModel();
                if (this.gridControl1.DataSource != null)
                {
                    DataTable tbl = this.gridControl1.DataSource as DataTable;
                    foreach (DataRow row in tbl.Rows)
                    {
                        string queueName = row[0].ToString().Trim();
                        uint i = model.QueueDelete(queueName);
                    }
                }
                conection.Close();
                MessageBox.Show("Đã xóa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
