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
using Castle.Components.DictionaryAdapter;
using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.Images;
using QT.Moduls;
using Websosanh.Core.Drivers.RabbitMQ;
using Websosanh.Core.Drivers.Solr;
using WSS.IndividualCategoryWebsites.SolrProduct;

namespace WSS.IndividualCategoryWebsites
{
    public partial class frmGetProductFromSolr : Form
    {
        private SolrProductClient solrProductClient;
        private static readonly ILog Log = LogManager.GetLogger(typeof(frmGetProductFromSolr));
        private long _websiteId = 1;
        public frmGetProductFromSolr()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            solrProductClient = SolrProductClient.GetClient(SolrClientManager.GetSolrClient("solrProducts"));
        }
        private void btnGetListProductFromSolr_Click(object sender, EventArgs e)
        {
            Wait.Show("Loading...");
            var limitResult = Convert.ToInt32(txtLimitResult.Text);
            var listkeywords = rbKeywords.Text.Split(new string[]{"\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberFound = 0;
            var result = solrProductClient.GetListProducts(listkeywords, 0, limitResult, out numberFound);
            gridControl1.DataSource = result;
            txtNumberFound.Text = numberFound.ToString();
            txtLimitPushMessage.Text = numberFound.ToString();
            Wait.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Wait.Show("Loading...");
            var limitResult = Convert.ToInt32(txtLimitPushMessage.Text);
            var listkeywords = rbKeywords.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberFound = 0;
            var listProduct = solrProductClient.GetListProducts(listkeywords, 0, limitResult, out numberFound);
            foreach (var product in listProduct)
            {
                product.WebsiteId = _websiteId;
            }
            var jsonobject = JsonConvert.SerializeObject(listProduct);
            SendMessageToServiceRootProduct(jsonobject);
            Wait.Close();
        }

        private void SendMessageToServiceRootProduct(string jsonObject)
        {
            var rabbitMqServer = RabbitMQManager.GetRabbitMQServer(ConfigRabbitMqIndividualCategoryWebsites.RabbitMqServerName);
            var individualJobClient = new ProducerBasic(rabbitMqServer, ConfigRabbitMqIndividualCategoryWebsites.ExchangeIndividual, ConfigRabbitMqIndividualCategoryWebsites.RoutingKeyIndividual);
            while (true)
            {
                try
                {
                    individualJobClient.Publish(UtilZipFile.Zip(jsonObject));
                    Log.Info(string.Format("Push message to services success."));
                    break;
                }
                catch (Exception exception)
                {
                    Log.Error(string.Format("Push message error."), exception);
                    Thread.Sleep(60000);
                }
            }
        }
    }
}
