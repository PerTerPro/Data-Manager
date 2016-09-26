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
using QT.Entities;
using WSS.Core.Crawler;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmCrawlerManal : Form
    {
        private long _companyId;
        private readonly CancellationTokenSource _cancellationTokenSource=new CancellationTokenSource();

        public FrmCrawlerManal()
        {
            InitializeComponent();
        }

        public FrmCrawlerManal(long companyId)
        {
            InitializeComponent();
            _companyId = companyId;
        }


        public void Start(bool bFN, List<string> linkStatic = null)
        {
            Company company = new Company(_companyId);

            if (bFN)
            {
                this.Text = @"FN:" + company.Domain;
                var token = _cancellationTokenSource.Token;
                Task.Factory.StartNew(() =>
                {
                    WorkerFindNew worker = new WorkerFindNew(_companyId, token,"" );
                    worker.EventReportRun += (data) =>
                    {
                        this.Invoke(new Action(() =>
                        {
                            txtReport.AppendText("\r\n" + data);
                        }));
                    };
                    worker.StartCrawler(linkStatic);
                }, token);
            }
            else
            {
                this.Text = @"RL:" + company.Domain;
                var token = _cancellationTokenSource.Token;
                Task.Factory.StartNew(() =>
                {
                    WorkerReload worker = new WorkerReload(_companyId, token, "");
                    worker.EventReportRun += (data) =>
                    {
                        this.Invoke(new Action(() =>
                        {
                            txtReport.AppendText("\r\n" + data);
                        }));
                    };
                    worker.StartCrawler();
                }, token);
            }
        }

        private void FrmCrawlerFindNew_Load(object sender, EventArgs e)
        {

        }
    }
}
