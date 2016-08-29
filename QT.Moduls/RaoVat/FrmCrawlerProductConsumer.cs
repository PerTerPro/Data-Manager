using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.RaoVat
{
    public partial class FrmCrawlerProductConsumer : Form
    {
        QT.Entities.RaoVat.ProductSaleNewDataAdapter adapter = null;
        private int RunnerCrawlerID;


        public FrmCrawlerProductConsumer()
        {
            InitializeComponent();
        }

        public FrmCrawlerProductConsumer(string domain, string name, int RunnerCrawler)
        {
            InitializeComponent();
            this.RunnerCrawlerID = RunnerCrawler;
            this.adapter = new Entities.RaoVat.ProductSaleNewDataAdapter(new Entities.Data.SqlDb(QT.Entities.Server.ConnectionString));
        }

        public void Start ()
        {
            
        }
    }
}
