using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmFindLinkProduct : Form
    {
        private string strFileConfig = "ConfigFindProduct.txt";
        public FrmFindLinkProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigCrawlerSelenium config = this.GetConfig();
            MessageBox.Show("Saved");
        }

        private ConfigCrawlerSelenium GetConfig()
        {
            var config = new ConfigCrawlerSelenium();
            config.MaxDeep = Convert.ToInt32(txtDepp.Text);
            config.RegexAcceptProduct = txtRegexAcceptProduct.Text.Split('\n').ToList();
            config.RegexToQueue = txtRegexAcceptToQueue.Text.Split('\n').ToList();
            config.XPathProduct = txtXpathToProduct.Text.Split('\n').ToList();
            config.QueueInit = txtQueueInit.Text.Split('\n').ToList();
            config.RootLInk = txtRootLInk.Text;
            File.WriteAllText(strFileConfig, config.GetJSON());
            return config;
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            string str = File.ReadAllText(strFileConfig);
            ConfigCrawlerSelenium config = ConfigCrawlerSelenium.FromJSON(str);
            LoadToForm(config);
        }

        private void LoadToForm(ConfigCrawlerSelenium config)
        {
            txtDepp.Text = config.MaxDeep.ToString();
            txtRegexAcceptProduct.Text = string.Join("\n", config.RegexAcceptProduct);
            txtRegexAcceptToQueue.Text = string.Join("\n", config.RegexToQueue);
            txtXpathToProduct.Text = string.Join("\n", config.XPathProduct);
            txtQueueInit.Text = string.Join("\n", config.QueueInit);
            txtRootLInk.Text = config.RootLInk;
            MessageBox.Show("Loaded");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           
            ConfigCrawlerSelenium config = this.GetConfig();
            Task.Factory.StartNew(() =>
                {
                    using (OpenQA.Selenium.Firefox.FirefoxDriver fireFoxDriver = new OpenQA.Selenium.Firefox.FirefoxDriver())
                    {
                        int countVisited = 0;
                        Uri rootLink = new Uri(config.RootLInk);
                        HashSet<long> crcVisited = new HashSet<long>();
                        Queue<string> queueLink = new Queue<string>();
                        HashSet<long> productLinks = new HashSet<long>();
                        queueLink.Enqueue(config.RootLInk);

                        foreach(var str in config.QueueInit)
                             queueLink.Enqueue(str);
                        while (queueLink.Count > 0)
                        {
                            string urlCurrent = queueLink.Dequeue();
                            fireFoxDriver.Url = urlCurrent;
                            Thread.Sleep(1000);
                            this.ShowLog(string.Format("GetJob: {0}", urlCurrent));
                            countVisited++;
                            var nodeLinks = fireFoxDriver.FindElementsByTagName("a");
                            if (nodeLinks!=null)
                            {
                                foreach(var node in nodeLinks)
                                {
                                    string linkNew = node.GetAttribute("href");
                                    if (!string.IsNullOrEmpty(linkNew))
                                    {
                                        linkNew = QT.Entities.Common.GetAbsoluteUrl(linkNew, rootLink);
                                        long IDNew = QT.Entities.Common.CrcProductID(linkNew);
                                        if (!crcVisited.Contains(IDNew) && QT.Entities.Common.CheckRegex(linkNew, config.RegexToQueue, null, false))
                                        {
                                            crcVisited.Add(IDNew);
                                            queueLink.Enqueue(linkNew);
                                        }
                                    }
                                }
                            }

                            var nodeLinkFindProduct = fireFoxDriver.FindElementsByXPath(config.XPathProduct[0]);
                            if (nodeLinkFindProduct!=null)
                            {
                                foreach (var nodeData in nodeLinkFindProduct)
                                {
                                    string linkNew = nodeData.GetAttribute("href");
                                    long IDNew = QT.Entities.Common.CrcProductID(linkNew);
                                    linkNew = QT.Entities.Common.GetAbsoluteUrl(linkNew, rootLink);
                                    if (!productLinks.Contains(IDNew)
                                            && QT.Entities.Common.CheckRegex(linkNew, config.RegexAcceptProduct, null, false))
                                    {
                                        productLinks.Add(IDNew);
                                        this.ShowLinkProduct(linkNew);
                                    }
                                }
                            }

                            this.ShowLog(string.Format("Queue: {0} CrcAdded: {1} Visited: {2}", queueLink.Count, crcVisited.Count, countVisited++));
                        }
                    }
                });
        }

        private void ShowLinkProduct(string url)
        {
            this.Invoke(new Action(() =>
                {
                    txtProductLink.AppendText("\r\n" + url);
                }));
        }

        private void ShowLog(string log)
        {
            this.Invoke(new Action(() =>
            {
                txtLog.AppendText("\r\n" + log);
            }));
        }
    }
}
