using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSS.WebMerchantSupport
{
    public partial class frmWebMerchantProduct : Form
    {
        private int _WebId;
        private string _Domain;
        public frmWebMerchantProduct()
        {
            InitializeComponent();
        }
        public frmWebMerchantProduct(int webId, string domain)
        {
            InitializeComponent();
            _WebId = webId;
            _Domain = domain;
        }

        private void frmWebMerchantProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
