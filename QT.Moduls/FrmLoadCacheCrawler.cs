using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls
{
    public partial class FrmLoadCacheCrawler : Form
    {
        public FrmLoadCacheCrawler()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => UpdateCacheProduct());
            thread.Start();
        }

        private void UpdateCacheProduct()
        {
            SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionStringCrawler);
            
        }

        private void LogData (string mss)
        {
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
