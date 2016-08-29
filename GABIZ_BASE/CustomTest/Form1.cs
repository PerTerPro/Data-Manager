using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websosanh.Core.Common.BAL;
using WSS.UpdateRootProductMappingSerivce;

namespace CustomTest
{
    public partial class Form1 : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSendUpdateRootIDJob_Click(object sender, EventArgs e)
        {
            WSS.UpdateRootProductMappingSerivce.UpdateRootProductMappingSerivce.JobRabbitMQ jobname = new WSS.UpdateRootProductMappingSerivce.UpdateRootProductMappingSerivce.JobRabbitMQ()
            {
                JobName = "UpdateProductIDToSQL",
                JobType = 1,
                JobInformation = textBoxProductID.Text
            };
            Producer producer = new Producer("192.168.100.135", "UpdateProductIDToSQL");
            byte[] messagenew = ProtobufTool.Serialize(jobname);
            if (producer.SendMessage(messagenew))
                Log.InfoFormat("Consumer1 sent message ID : {0}", jobname.JobInformation);
            else
                Log.ErrorFormat("Consumer1 send message FAILS with ID = {0}", jobname.JobInformation);

            producer.Dispose();
        }
    }
}
