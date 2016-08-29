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
    public partial class FrmRegexManager : Form
    {
        public FrmRegexManager()
        {
            InitializeComponent();
            this.regexCityTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringCrawler;
        }

        private void regexCityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regexCityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBRegex);

        }

        private void FrmRegexManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBRegex.RegexCity' table. You can move, or remove it, as needed.
            this.regexCityTableAdapter.Fill(this.dBRegex.RegexCity);

        }

        private void FrmRegexManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                regexCityBindingNavigatorSaveItem_Click(null, null);
            }
        }
    }
}
