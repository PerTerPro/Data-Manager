using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.KeywordSuggest
{
    public partial class FrmViewHistoryVolume : Form
    {
        SqlDb sqlDb = new SqlDb(QT.Entities.Server.ConnectionString);
        public FrmViewHistoryVolume()
        {
            InitializeComponent();
        }

        private void FrmViewHistoryVolume_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {
            var tbl = this.sqlDb.GetTblData("select * from Keyword_VolumeHistory", CommandType.Text, null);
            this.gridControl1.DataSource = tbl;
        }
    }
}
