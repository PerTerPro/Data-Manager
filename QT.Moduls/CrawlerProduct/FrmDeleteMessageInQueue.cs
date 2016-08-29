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
    public partial class FrmDeleteMessageInQueue : Form
    {
        CancellationTokenSource cancelTokenSource = null;
        RabbitMQServer rabbitMQServer = null;
        Worker[] workers = null;
        int workerCount = 5;
        string strQueue = "";
        public FrmDeleteMessageInQueue()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            strQueue = cboQueue.Text;
            cancelTokenSource = new CancellationTokenSource();
            string rabbitMQServerName = "rabbitMQ177";
            workers = new Worker[workerCount];
            rabbitMQServer = RabbitMQManager.GetRabbitMQServer(rabbitMQServerName);
            for (int i = 0; i < workerCount; i++)
            {
                var worker = new Worker(strQueue, false, rabbitMQServer);
                workers[i] = worker;
                var token = this.cancelTokenSource.Token;
                Task workerTask = new Task(() =>
                {
                    worker.JobHandler = (updateDatafeedJob) =>
                    {
                        try
                        {
                            return true;
                        }
                        catch (OperationCanceledException opc)
                        {
                            
                            return true;
                        }
                        catch (Exception ex01)
                        {
                            
                            return true;
                        }
                    };
                    worker.Start();
                }, token);
                workerTask.Start();
            }
        }

    }
}
