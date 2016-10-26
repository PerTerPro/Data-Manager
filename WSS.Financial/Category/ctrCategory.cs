using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace WSS.Financial.Backend.Category
{
    public partial class ctrCategory : UserControl
    {
        public delegate void ChangedEventHandler(EventArgs e);
        public event ChangedEventHandler IdCategoryChanged;
        private static readonly ILog Log = LogManager.GetLogger(typeof(ctrCategory));
        public ctrCategory()
        {
            InitializeComponent();
        }
        public void InitControl()
        {
            categoryTableAdapter.Connection.ConnectionString = WssConnectionFinancial.ConnectionFinancial;
            try
            {
                categoryTableAdapter.Fill(dBFinancial.Category);
                treeListCategory.ExpandAll();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Log.Error(exception);
            }
        }
        public int GetIdCategoryCurrent()
        {
            if (!string.IsNullOrEmpty(idTextEdit.Text))
                return Convert.ToInt32(idTextEdit.Text);
            else
                return 0;
        }
        public string GetCategpryNameCurrent()
        {
            return this.nameTextEdit.Text;
        }
        private void idTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            IdCategoryChanged(e);}
    }
}
