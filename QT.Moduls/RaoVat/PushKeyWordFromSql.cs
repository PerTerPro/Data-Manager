using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlSale;
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

namespace QT.Moduls.RaoVat
{
    public partial class FrmPushKeyWordFroSql : Form
    {
        RaoVat.ProductSaleNewAdapter raovatAdapter = new ProductSaleNewAdapter(new SqlDb(QT.Entities.Server.ConnectionStringCrawler));
        private Thread thread;

        public FrmPushKeyWordFroSql()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {

                        MongoDbRaoVat mongoAdapter = new MongoDbRaoVat();
                        DataTable tblData = raovatAdapter.GetTblKeyWordNeedUpdate();
                        if (tblData.Rows.Count == 0) return;
                        else
                        {
                            foreach (DataRow row in tblData.Rows)
                            {
                                long crc = Convert.ToInt64(row["id"]);
                                string name = Convert.ToString(row["name"]);
                                string slug = Convert.ToString(row["name"]).Replace(" ", "-");
                                mongoAdapter.UpdateKeyWordRaoVat("0", crc, name, slug, "", "");
                                this.raovatAdapter.UpdateStateOfKeyWord(crc, 1);

                                this.Invoke(new Action(() =>
                                    {
                                        spinEdit1.Value = Convert.ToInt32(spinEdit1.Value) + 1;
                                        label1.Text = name;
                                    }));
                            }
                        }

                    }
                    catch (ThreadAbortException ex)
                    {
                        return;
                    }
                    catch (Exception ex1)
                    {
                        Thread.Sleep(1000);
                    }
                }
            });
            thread.Start();
        }

        private void PushKeyWordFromSql_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread != null && this.thread.IsAlive) this.thread.Abort();

        }

        private void btnTransferKeyWord_Click(object sender, EventArgs e)
        {

        }
    }
}
