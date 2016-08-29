using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmPushProductSolr : Form
    {
        public FrmPushProductSolr()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int iCount = 0;
            List<string> lstProduct = QT.Entities.Common.GetListXPathFromString(richTextBox1.Text);
            if (lstProduct.Count > 0)
            {
                foreach (string strProductID in lstProduct)
                {
                    long ProductID = QT.Entities.Common.Obj2Int64(strProductID);
                    if (ProductID > 0)
                    {
                        RabbitMQAdapter.Instance.PushProductToQueueChangeMainInfo(ProductID);
                        iCount++;
                    }
                }
            }
            MessageBox.Show("Pushed:" + iCount.ToString());
        }
    }
}
