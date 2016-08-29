using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.JobServer;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmReportReloadTimeNewProduct : Form
    {
        log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(FrmReportReloadTimeNewProduct));
        BindingList<Product> lstProductChanged = new BindingList<Product>();

        public FrmReportReloadTimeNewProduct()
        {
            InitializeComponent();
        }

        public void StartRun()
        {
            Task.Factory.StartNew(() =>
                {
                    try
                    {
                        InitializeComponent();
                        var cancelUpdateDataFeedTokenSource = new CancellationTokenSource();
                        string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                        Server.LogConnectionString = ConfigurationManager.AppSettings["LogConnectionString"];
                        QT.Entities.Server.ConnectionString = connectionString;
                        string rabbitMQServerName = ConfigurationManager.AppSettings["rabbitMQServerName"];
                        //worker
                        string updateDatafeedJobName = ConfigurationManager.AppSettings["updateDatafeedJobName"];
                        ;
                        var rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);

                        var worker = new Worker(updateDatafeedJobName, false, rabbitMQServer);
                        Task workerTask = new Task(() =>
                        {
                            worker.JobHandler = (updateDatafeedJob) =>
                            {
                                return true;
                            };
                            worker.Start();
                        });
                        workerTask.Start();
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Start error", ex);
                        throw;
                    }
                });
        }

        private void FrmReportReloadTimeNewProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qT_2DataSetRealTime.prc_RealTime_TotalNewProduct' table. You can move, or remove it, as needed.
            this.prc_RealTime_TotalNewProductTableAdapter.Fill(this.qT_2DataSetRealTime.prc_RealTime_TotalNewProduct);

            this.gridControl1.DataSource = this.realTimeSource1;
        }
    }
}
